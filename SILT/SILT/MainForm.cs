using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILT
{
    public partial class MainForm : Form
    {
        #region Member Fields
        private string _workingDirectory;
        private Image[] _images = new Image[3];
        private string _currentImageFile;
        private List<string> _undoFiles = new List<string>();
        private const int _MAX_LABELS = 13;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }
        #endregion

        #region Events
        /// <summary>
        /// Button event to show a dialog for selecting the directory which holds the to be labelled images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChooseDirectoryClick(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    string[] files = Directory.GetFiles(dialog.SelectedPath);
                    _workingDirectory = dialog.SelectedPath;
                    directoryPathText.Text = dialog.SelectedPath;

                    // Load Images
                    LoadImages();

                    // Load Labels
                    LoadLabels();
                }
            }
        }

        /// <summary>
        /// Button event to undo a label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        /// <summary>
        /// Key pressed event for undoing a label (F8) or updating the images (F5).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.F8)) // F8 key
            {
                Undo();
            }
            else if(e.KeyCode.Equals(Keys.F5)) // F5 key
            {
                LoadImages();
            }
        }
        
        #region Do label button click events
        private void DoLabelButton0_Click(object sender, EventArgs e)
        {
            ApplyLabel(label0.Text, _currentImageFile);
        }

        private void DoLabelButton1_Click(object sender, EventArgs e)
        {
            ApplyLabel(label1.Text, _currentImageFile);
        }

        private void DoLabelButton2_Click(object sender, EventArgs e)
        {
            ApplyLabel(label2.Text, _currentImageFile);
        }

        private void DoLabelButton3_Click(object sender, EventArgs e)
        {
            ApplyLabel(label3.Text, _currentImageFile);
        }

        private void DoLabelButton4_Click(object sender, EventArgs e)
        {
            ApplyLabel(label4.Text, _currentImageFile);
        }

        private void DoLabelButton5_Click(object sender, EventArgs e)
        {
            ApplyLabel(label5.Text, _currentImageFile);
        }

        private void DoLabelButton6_Click(object sender, EventArgs e)
        {
            ApplyLabel(label6.Text, _currentImageFile);
        }

        private void DoLabelButton7_Click(object sender, EventArgs e)
        {
            ApplyLabel(label7.Text, _currentImageFile);
        }

        private void DoLabelButton8_Click(object sender, EventArgs e)
        {
            ApplyLabel(label8.Text, _currentImageFile);
        }

        private void DoLabelButton9_Click(object sender, EventArgs e)
        {
            ApplyLabel(label9.Text, _currentImageFile);
        }

        private void DoLabelButton10_Click(object sender, EventArgs e)
        {
            ApplyLabel(label10.Text, _currentImageFile);
        }

        private void DoLabelButton11_Click(object sender, EventArgs e)
        {
            ApplyLabel(label11.Text, _currentImageFile);
        }

        private void DoLabelButton12_Click(object sender, EventArgs e)
        {
            ApplyLabel(label12.Text, _currentImageFile);
        }

        private void DoLabelButton13_Click(object sender, EventArgs e)
        {
            ApplyLabel(label13.Text, _currentImageFile);
        }

        private void DoLabelButton14_Click(object sender, EventArgs e)
        {
            ApplyLabel(label14.Text, _currentImageFile);
        }

        private void DoLabelButton15_Click(object sender, EventArgs e)
        {
            ApplyLabel(label15.Text, _currentImageFile);
        }

        private void DoLabelButton16_Click(object sender, EventArgs e)
        {
            ApplyLabel(label16.Text, _currentImageFile);
        }

        private void DoLabelButton17_Click(object sender, EventArgs e)
        {
            ApplyLabel(label17.Text, _currentImageFile);
        }

        private void DoLabelButton18_Click(object sender, EventArgs e)
        {
            ApplyLabel(label18.Text, _currentImageFile);
        }

        private void DoLabelButton19_Click(object sender, EventArgs e)
        {
            ApplyLabel(label19.Text, _currentImageFile);
        }

        private void DoLabelButton20_Click(object sender, EventArgs e)
        {
            ApplyLabel(label20.Text, _currentImageFile);
        }

        private void DoLabelButton21_Click(object sender, EventArgs e)
        {
            ApplyLabel(label21.Text, _currentImageFile);
        }

        private void DoLabelButton22_Click(object sender, EventArgs e)
        {
            ApplyLabel(label22.Text, _currentImageFile);
        }

        private void DoLabelButton23_Click(object sender, EventArgs e)
        {
            ApplyLabel(label23.Text, _currentImageFile);
        }

        private void DoLabelButton24_Click(object sender, EventArgs e)
        {
            ApplyLabel(label24.Text, _currentImageFile);
        }

        private void DoLabelButton25_Click(object sender, EventArgs e)
        {
            ApplyLabel(label25.Text, _currentImageFile);
        }
        #endregion
        #endregion

        #region Private Functions
        /// <summary>
        /// Creates a clone from an image.
        /// </summary>
        /// <param name="path">File path to the image.</param>
        /// <returns></returns>
        private Image CloneImage(string path)
        {
            using (Image source = Image.FromFile(path))
            {
                Image clone = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppArgb);
                using (var copy = Graphics.FromImage(clone))
                {
                    copy.DrawImage(source, 0, 0);
                }
                return clone;
            }
        }

        /// <summary>
        /// Loads images and updates the UI.
        /// </summary>
        private void LoadImages()
        {
            // Get all files of the workind directory
            string[] files = Directory.GetFiles(_workingDirectory);
            
            if (files.Length > 0)
            {
                _currentImageFile = files[0];

                // Load and display images
                toLabelPicture.Image = CloneImage(files[0]);
                if (files.Length > 1)
                {
                    picturePreview1.Image = CloneImage(files[1]);
                }
                else
                {
                    picturePreview1.Image = null;
                }

                if (files.Length > 2)
                {
                    picturePreview2.Image = CloneImage(files[2]);
                }
                else
                {
                    picturePreview2.Image = null;
                }
            }
            else
            {
                toLabelPicture.Image = null;
                _currentImageFile = "";
            }

            remainingImagesText.Text = "Remaining Images: " + files.Length;
        }

        /// <summary>
        /// Loads labels, if subdirectories are present.
        /// </summary>
        private void LoadLabels()
        {
            // Get subdirectories
            string[] directories = Directory.GetDirectories(_workingDirectory);

            // Return if there are no subdirectories
            if(directories.Length.Equals(0))
            {
                return;
            }

            // More than 13 labels are not supported
            if(directories.Length > _MAX_LABELS)
            {
                throw new ApplicationException("Expected less than " + (_MAX_LABELS + 1) + "subdirectories, but found " + directories.Length);
            }

            // Apply labels to text boxes
            List<TextBox> labelTextBoxes = new List<TextBox>();
            // Find all text boxes, which hold labels
            foreach(Control c in this.Controls)
            {
                if(c.Tag != null && c.Tag.Equals("labels"))
                {
                    labelTextBoxes.Add((TextBox)c);
                }
            }

            for(int i = 0; i < directories.Length; i++)
            {
                labelTextBoxes[i].Text = new DirectoryInfo(directories[i]).Name;
            }
        }

        /// <summary>
        /// Applies the label to the image by moving it into the labels subdirectory.
        /// Dispose image resources.
        /// </summary>
        /// <param name="label">Label, which is the name of the directory.</param>
        /// <param name="file">Path to image file which has to be moved to the label's directory.</param>
        private void ApplyLabel(string label, string file)
        {
            // Check if a label was entered
            if(label.Length == 0)
            {
                return;
            }

            // Check if no file is supplied (i.e. no files remain to be labeled)
            if(_currentImageFile.Equals(""))
            {
                return;
            }

            string targetDirectory = @_workingDirectory + "/" + label;

            // Check if directory exists, if not create it
            if(!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            // Move file
            string targetPath = targetDirectory + "/" + Path.GetFileName(file);
            File.Move(file, targetPath);
            // Save reference for undo
            _undoFiles.Add(targetPath);

            // Update undo picture boxes
            pictureUndo2.Image = pictureUndo1.Image;
            pictureUndo1.Image = toLabelPicture.Image;

            // Load the next images
            LoadImages();
        }

        /// <summary>
        /// Undoes the last labeling. It moves the file back from the label's subdirectory and updates the picture boxes.
        /// </summary>
        private void Undo()
        {
            if(_undoFiles.Any()) // Check if items are available for being undone.
            {
                // Move last file back to the working directory
                string lastFile = _undoFiles[_undoFiles.Count - 1];
                File.Move(lastFile, @_workingDirectory + "/" + Path.GetFileName(lastFile));

                // Update picture preview boxes
                if (_undoFiles.Count > 1)
                {
                    pictureUndo1.Image = CloneImage(_undoFiles[_undoFiles.Count - 2]);
                }
                else
                {
                    pictureUndo1.Image = null;
                }

                if (_undoFiles.Count > 2)
                {
                    pictureUndo2.Image = CloneImage(_undoFiles[_undoFiles.Count - 3]);
                }
                else
                {
                    pictureUndo2.Image = null;
                }

                // Remove the undone file from the list
                _undoFiles.RemoveAt(_undoFiles.Count - 1);

                // Reload the to be labeled images
                LoadImages();
            }
        }
        #endregion
    }
}
