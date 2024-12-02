using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.ImageRendering;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.ColorManagement;

namespace LargeImageViewerDemo
{
    /// <summary>
    /// The main form of Large Image Viewer Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Template of the application title.
        /// </summary>
        string _titlePrefix = string.Format("VintaSoft Large Image Viewer Demo v{0}", ImagingGlobalSettings.ProductVersion);

        /// <summary>
        /// A value indicating whether zoom changing is disabled.
        /// </summary>
        bool _disableChangeZoom = false;

        /// <summary>
        /// An image map tool.
        /// </summary>
        ImageMapTool _imageMapTool;

        /// <summary>
        /// Current application window state.
        /// </summary>
        FormWindowState _windowState;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes the <see cref="MainForm"/> class.
        /// </summary>
        static MainForm()
        {
            WsiCodecAssembly.Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            // set CustomFontProgramsController for all opened documents
            CustomFontProgramsController.SetDefaultFontProgramsController();

            Jpeg2000AssemblyLoader.Load();

            Text = _titlePrefix;

            _disableChangeZoom = true;
            zoomComboBox.Text = imageViewer1.Zoom.ToString();
            _disableChangeZoom = false;

            imageViewer1.CenterImage = true;

            _imageMapTool = new ImageMapTool();
            _imageMapTool.Enabled = true;
            _imageMapTool.Anchor = AnchorType.Bottom | AnchorType.Left;
            _imageMapTool.Size = new Size(250, 250);
            _imageMapTool.Zoom = 0;
            SetNewVisualTool(null);

            // set filters in open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openImageFileDialog);

            // set the initial directory in open file dialog
            DemosTools.SetTestFilesFolder(openImageFileDialog);

            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.Zoom);
            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.Normal);
            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.BestFit);
            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.FitToWidth);
            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.FitToHeight);
            sizeModeToolStripComboBox.Items.Add(ImageSizeMode.PixelToPixel);
            sizeModeToolStripComboBox.SelectedItem = imageViewer1.SizeMode;

            // enable dynamic rendering of PDF documents
            imageViewer1.RenderingRequirements.SetRequirement("Pdf", new ImageSizeRenderingRequirement(0));

            // set viewer buffer size to 8 MPX
            imageViewer1.ViewerBufferSize = 8;

            // set renderer cache size to 512 MB
            imageViewer1.RendererCacheSize = 512;

            showScrollbarsToolStripMenuItem.Checked = imageViewer1.AutoScroll;

            imageViewer1.SizeMode = ImageSizeMode.BestFit;


            // initialize color management in viewer
            ColorManagementHelper.EnableColorManagement(imageViewer1);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Get or sets the zoom of the image, in percents.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float Zoom
        {
            get
            {
                return imageViewer1.ZoomExtended;
            }
            set
            {
                imageViewer1.ZoomExtended = value;
                float maxZ = MaxZoom;
                if (value > maxZ)
                {
                    MaxZoom = value;
                    maxZ = value;
                }
                _disableChangeZoom = true;
                zoomTrackBar.Value = Math.Max(1, (int)Math.Round(zoomTrackBar.Maximum / (maxZ / value)));
                zoomComboBox.Text = value.ToString("f2", CultureInfo.InvariantCulture);
                _disableChangeZoom = false;
            }
        }

        /// <summary>
        /// Get or sets the maximum zoom of the image.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float MaxZoom
        {
            get
            {
                return Convert.ToSingle(maxZoomToolStripComboBox.Text, CultureInfo.InvariantCulture);
            }
            set
            {
                maxZoomToolStripComboBox.Text = value.ToString(CultureInfo.InvariantCulture);
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Processes a command key.
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />,
        /// passed by reference, that represents the window message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values
        /// that represents the key to process.</param>
        /// <returns>
        /// <b>true</b> if the character was processed by the control; otherwise, <b>false</b>.
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Control | Keys.Add))
            {
                RotateViewClockwise();
                return true;
            }

            if (keyData == (Keys.Shift | Keys.Control | Keys.Subtract))
            {
                RotateViewCounterClockwise();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion


        #region PRIVATE

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                CloseImage();
                OpenImage(openImageFileDialog.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of closeToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseImage();
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of rotateClockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewClockwise();
        }

        /// <summary>
        /// Handles the Click event of rotateCounterclockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateCounterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewCounterClockwise();
        }

        /// <summary>
        /// Handles the Click event of imageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImageViewerSettingsForm viewerSettingsDialog = new ImageViewerSettingsForm(imageViewer1))
            {
                viewerSettingsDialog.CanEditMultipageSettings = false;
                viewerSettingsDialog.TopMost = TopMost;
                viewerSettingsDialog.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of imageMapSettingsToolStripMenuItem object.
        /// </summary>
        private void imageMapSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImageMapToolSettingsForm mapSettingsDialog = new ImageMapToolSettingsForm(_imageMapTool))
            {
                mapSettingsDialog.TopMost = TopMost;
                mapSettingsDialog.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of fullScreenToolStripMenuItem object.
        /// </summary>
        private void fullScreenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (fullScreenToolStripMenuItem.Checked)
            {
                // enable full screen mode
                statusStripPanel.Visible = false;
                if (!topPanelAlwaysVisibleToolStripMenuItem.Checked)
                    topPanel.Visible = false;

                TopMost = true;
                _windowState = WindowState;
                FormBorderStyle = FormBorderStyle.None;
                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;

                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // disable full screen mode
                statusStripPanel.Visible = true;
                topPanel.Visible = true;
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                if (WindowState != _windowState)
                    WindowState = _windowState;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of showScrollbarsToolStripMenuItem object.
        /// </summary>
        private void showScrollbarsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // show/hide scrollbars in image viewer
            imageViewer1.AutoScroll = showScrollbarsToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the CheckedChanged event of topPanelAlwaysVisibleToolStripMenuItem object.
        /// </summary>
        private void topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (topPanelAlwaysVisibleToolStripMenuItem.Checked)
            {
                // show top panel
                topPanel.Visible = true;
            }
            else if (fullScreenToolStripMenuItem.Checked)
            {
                // hide top panel
                topPanel.Visible = false;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of sizeModeToolStripComboBox object.
        /// </summary>
        private void sizeModeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageViewer1.SizeMode = (ImageSizeMode)sizeModeToolStripComboBox.SelectedItem;
        }

        /// <summary>
        /// Handles the Click event of colorManagementToolStripMenuItem object.
        /// </summary>
        private void colorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorManagementSettingsForm.EditColorManagement(imageViewer1);
        }

        #endregion


        #region 'Visual Tools' menu

        /// <summary>
        /// Handles the Click event of noneToolStripMenuItem object.
        /// </summary>
        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // disable visual tool in image viewer
            SetNewVisualTool(null);
        }

        /// <summary>
        /// Handles the Click event of zoomToolStripMenuItem object.
        /// </summary>
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and set ZoomTool as current visual tool in image viewer
            ZoomTool zoomTool = new ZoomTool();
            zoomTool.ZoomStep = 20;
            SetNewVisualTool(zoomTool);
        }

        /// <summary>
        /// Handles the Click event of zoomToSelectionToolStripMenuItem object.
        /// </summary>
        private void zoomToSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and set ZoomSelectionTool as current visual tool in image viewer
            SetNewVisualTool(new ZoomSelectionTool());
        }

        /// <summary>
        /// Handles the Click event of panToolStripMenuItem object.
        /// </summary>
        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and set PanTool as current visual tool in image viewer
            SetNewVisualTool(new PanTool());
        }

        /// <summary>
        /// Handles the Click event of magnifierToolStripMenuItem object.
        /// </summary>
        private void magnifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and set MagnifierTool as current visual tool in image viewer
            MagnifierTool magnifierTool = new MagnifierTool();
            magnifierTool.Size = new Size(250, 250);
            SetNewVisualTool(magnifierTool);
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.TopMost = TopMost;
                dlg.ShowDialog();
            }
        }

        #endregion


        #region Main Form

        /// <summary>
        /// Handles the KeyDown event of MainForm object.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && fullScreenToolStripMenuItem.Checked)
                fullScreenToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Handles the FormClosed event of MainForm object.
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseImage();
        }

        #endregion


        #region Zoom

        /// <summary>
        /// Handles the ValueChanged event of zoomTrackBar object.
        /// </summary>
        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateZoom();
        }

        /// <summary>
        /// Handles the KeyDown event of zoomComboBox object.
        /// </summary>
        private void zoomComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetZoomValueFromZoomComboBox();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of zoomComboBox object.
        /// </summary>
        private void zoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetZoomValueFromZoomComboBox();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of maxZoomToolStripComboBox object.
        /// </summary>
        private void maxZoomToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateZoom();
        }

        /// <summary>
        /// Handles the KeyDown event of maxZoomToolStripComboBox object.
        /// </summary>
        private void maxZoomToolStripComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    UpdateZoom();
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the ZoomChanged event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_ZoomChanged(object sender, ZoomChangedEventArgs e)
        {
            Zoom = imageViewer1.ZoomExtended;
        }

        #endregion

        #endregion


        /// <summary>
        /// Opens new image.
        /// </summary>
        /// <param name="filename">The name of the file to open.</param>
        private void OpenImage(string filename)
        {
            // focused index
            int focusedIndex;

            // select image from file
            using (ImageCollection images = SelectImageForm.SelectImageFromFile(filename, out focusedIndex))
            {

                if (focusedIndex == -1)
                    return;

                VintasoftImage image = images[focusedIndex];

                // count image megapixels
                string sizeInfo;
                float mpx = (float)image.Width * image.Height / (1000f * 1000f);
                if (mpx < 0.01)
                {
                    sizeInfo = (image.Width * image.Height).ToString() + " Pixels";
                }
                else if (mpx < 10)
                {
                    sizeInfo = mpx.ToString("F2", CultureInfo.InvariantCulture) + " Megapixels";
                }
                else if (mpx < 1000)
                {
                    sizeInfo = mpx.ToString("F1", CultureInfo.InvariantCulture) + " Megapixels";
                }
                else
                {
                    sizeInfo = (mpx / 1000f).ToString("F2", CultureInfo.InvariantCulture) + " Gigapixels";
                }

                // update image info
                string codecName = image.SourceInfo.DecoderName;
                string primaryCodecName = image.SourceInfo.Decoder.GetPrimaryDecoderName(image.SourceInfo.PageIndex);
                if (codecName != primaryCodecName)
                    codecName = string.Format("{0} ({1})", codecName, primaryCodecName);
                Text = string.Format("{0}{1}", _titlePrefix, string.Format(" - {0} ({1})", Path.GetFileName(filename), sizeInfo));
                imageInfoToolStripStatusLabel.Text = string.Format("Codec={0}; PixelFormat={1}; Resolution={2}; Size={3}x{4} px",
                    codecName, image.PixelFormat, image.Resolution, image.Width, image.Height);

                float maxZoom = (float)Math.Max(image.Resolution.Vertical, image.Resolution.Horizontal) / 96f * 100f * 2;
                MaxZoom = (float)Math.Ceiling(maxZoom / 100f) * 100f;

                // add images to viewer
                imageViewer1.Images.AddRange(images.ToArray());
                imageViewer1.FocusedIndex = focusedIndex;
                images.Clear();
            }
        }

        /// <summary>
        /// Handler of the ImageViewer.ImageLoadingProgress event.
        /// </summary>
        private void imageViewer1_FocusedImageLoadingProgress(object sender, ProgressEventArgs e)
        {
            imageLoadProgressBar.Visible = e.Progress != 100;
            imageLoadProgressBar.Value = e.Progress;
        }

        /// <summary>
        /// Closes the image.
        /// </summary>
        private void CloseImage()
        {
            imageViewer1.Images.ClearAndDisposeItems();
            Text = _titlePrefix;
            imageInfoToolStripStatusLabel.Text = "";
        }

        /// <summary>
        /// Sets the new visual tool in image viewer.
        /// </summary>
        /// <param name="tool">New visual tool to set.</param>
        private void SetNewVisualTool(VisualTool tool)
        {
            VisualTool lastTool = imageViewer1.VisualTool;

            // if new tool is NOT specified
            if (tool == null)
            {
                // set image map tool
                imageViewer1.VisualTool = _imageMapTool;
            }
            else
            {
                // combine new tool with image map tool
                imageViewer1.VisualTool = new CompositeVisualTool(false, _imageMapTool, tool);
            }

            // if previous tool is not image map tool
            if (lastTool != null && lastTool != _imageMapTool)
            {
                // if previous tool is composite tool
                CompositeVisualTool compositeTool = lastTool as CompositeVisualTool;
                if (compositeTool != null)
                {
                    // dispose everything except image map tool
                    foreach (VisualTool visualTool in compositeTool)
                    {
                        if (visualTool != _imageMapTool)
                            visualTool.Dispose();
                    }
                }

                lastTool.Dispose();
            }
        }

        /// <summary>
        /// Changes the size mode and the zoom in the image viewer.
        /// </summary>
        private void UpdateZoom()
        {
            if (!_disableChangeZoom)
            {
                imageViewer1.SizeMode = ImageSizeMode.Zoom;
                sizeModeToolStripComboBox.SelectedItem = ImageSizeMode.Zoom;
                Zoom = (float)zoomTrackBar.Value / zoomTrackBar.Maximum * MaxZoom;
            }
        }

        /// <summary>
        /// Sets the zoom selected in zoom comboBox.
        /// </summary>
        private void SetZoomValueFromZoomComboBox()
        {
            try
            {
                if (!_disableChangeZoom)
                {
                    float newZoom = float.Parse(zoomComboBox.Text, CultureInfo.InvariantCulture);
                    imageViewer1.SizeMode = ImageSizeMode.Zoom;
                    sizeModeToolStripComboBox.SelectedItem = ImageSizeMode.Zoom;
                    Zoom = newZoom;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Rotates the image in the image viewer by 90 degrees clockwise.
        /// </summary>
        private void RotateViewClockwise()
        {
            imageViewer1.RotateViewClockwise();
        }

        /// <summary>
        /// Rotates the image in the image viewer by 90 degrees counterclockwise.
        /// </summary>
        private void RotateViewCounterClockwise()
        {
            imageViewer1.RotateViewCounterClockwise();
        }

        #endregion

        #endregion

    }
}
