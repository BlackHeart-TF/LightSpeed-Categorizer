using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorizer
{
    class ItemControl : System.Windows.Forms.UserControl
    {
        private LightspeedNET.Models.Item _item;
        public LightspeedNET.Models.Item Item { get { return _item; } 
            set 
            { 
                _item = value;
                if (value != null)
                {
                    ItemCount = 1;
                    Description.Text = value.Description;
                    Category.Text = value.Category.FullPathName;
                    if (value.FirstImage != null)
                        Image.Load(value.FirstImage);
                    labelCategory.Visible = true;
                    Category.Visible = true;
                    Image.Visible = true;
                }
            } }


        private int _itemcount;
        public int ItemCount { get { return _itemcount; } 
            set {
                _itemcount = value;
                if (_itemcount > 1) {
                    _item = null;
                    Description.Text = $"{ItemCount} items selected";
                    labelCategory.Visible = false;
                    Category.Visible = false;
                    Image.Visible = false;
                        }
            } }

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.PictureBox Image;

        public ItemControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelDescription = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(3, 8);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(232, 20);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description:";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(3, 28);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(257, 20);
            this.Description.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.Location = new System.Drawing.Point(3, 48);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(232, 20);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category:";
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.Location = new System.Drawing.Point(3, 68);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(257, 20);
            this.Category.TabIndex = 0;
            // 
            // Image
            // 
            this.Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image.Location = new System.Drawing.Point(3, 91);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(257, 256);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // ItemControl
            // 
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Image);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(263, 350);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
