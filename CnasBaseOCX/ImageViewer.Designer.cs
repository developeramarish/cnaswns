﻿using Cnas.wns.CnasBaseUC.Properties;
namespace Cnas.wns.CnasBaseUC
{
    partial class ImageViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            DisposeControl();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panelPreview = new System.Windows.Forms.Panel();
			this.lblPreview = new System.Windows.Forms.Label();
			this.cbZoom = new System.Windows.Forms.ComboBox();
			this.panelNavigation = new System.Windows.Forms.Panel();
			this.lblNavigation = new System.Windows.Forms.Label();
			this.tbNavigation = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
			this.btnPreview = new System.Windows.Forms.Button();
			this.btnMode = new System.Windows.Forms.Button();
			this.btnZoomIn = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnZoomOut = new System.Windows.Forms.Button();
			this.btnFitToScreen = new System.Windows.Forms.Button();
			this.btnRotate90 = new System.Windows.Forms.Button();
			this.btnRotate270 = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pbPanel = new System.Windows.Forms.PictureBox();
			this.pbFull = new Cnas.wns.CnasBaseUC.PanelDoubleBuffered();
			this.sbVert = new System.Windows.Forms.VScrollBar();
			this.sbHoriz = new System.Windows.Forms.HScrollBar();
			this.sbPanel = new System.Windows.Forms.Panel();
			this.panelPreview.SuspendLayout();
			this.panelNavigation.SuspendLayout();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPanel)).BeginInit();
			this.pbFull.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPreview
			// 
			this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelPreview.BackColor = System.Drawing.SystemColors.Control;
			this.panelPreview.Controls.Add(this.lblPreview);
			this.panelPreview.Location = new System.Drawing.Point(418, 0);
			this.panelPreview.Name = "panelPreview";
			this.panelPreview.Size = new System.Drawing.Size(150, 30);
			this.panelPreview.TabIndex = 12;
			// 
			// lblPreview
			// 
			this.lblPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPreview.AutoSize = true;
			this.lblPreview.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPreview.ForeColor = System.Drawing.Color.Black;
			this.lblPreview.Location = new System.Drawing.Point(3, 6);
			this.lblPreview.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.lblPreview.Name = "lblPreview";
			this.lblPreview.Size = new System.Drawing.Size(42, 18);
			this.lblPreview.TabIndex = 0;
			this.lblPreview.Text = "预览";
			// 
			// cbZoom
			// 
			this.cbZoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbZoom.FormattingEnabled = true;
			this.cbZoom.Location = new System.Drawing.Point(243, 5);
			this.cbZoom.Name = "cbZoom";
			this.cbZoom.Size = new System.Drawing.Size(62, 20);
			this.cbZoom.TabIndex = 14;
			this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
			this.cbZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbZoom_KeyPress);
			// 
			// panelNavigation
			// 
			this.panelNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelNavigation.BackColor = System.Drawing.SystemColors.Control;
			this.panelNavigation.Controls.Add(this.lblNavigation);
			this.panelNavigation.Controls.Add(this.tbNavigation);
			this.panelNavigation.Controls.Add(this.btnBack);
			this.panelNavigation.Controls.Add(this.btnNext);
			this.panelNavigation.Location = new System.Drawing.Point(418, 145);
			this.panelNavigation.Name = "panelNavigation";
			this.panelNavigation.Size = new System.Drawing.Size(150, 27);
			this.panelNavigation.TabIndex = 13;
			// 
			// lblNavigation
			// 
			this.lblNavigation.AutoSize = true;
			this.lblNavigation.BackColor = System.Drawing.SystemColors.Control;
			this.lblNavigation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNavigation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNavigation.Location = new System.Drawing.Point(41, 5);
			this.lblNavigation.Name = "lblNavigation";
			this.lblNavigation.Size = new System.Drawing.Size(24, 18);
			this.lblNavigation.TabIndex = 1;
			this.lblNavigation.Text = "/ 0";
			// 
			// tbNavigation
			// 
			this.tbNavigation.Location = new System.Drawing.Point(4, 4);
			this.tbNavigation.Name = "tbNavigation";
			this.tbNavigation.Size = new System.Drawing.Size(33, 21);
			this.tbNavigation.TabIndex = 19;
			this.tbNavigation.Text = "0";
			this.tbNavigation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbNavigation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNavigation_KeyPress);
			// 
			// btnBack
			// 
			this.btnBack.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnBack;
			this.btnBack.Location = new System.Drawing.Point(93, 1);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(25, 23);
			this.btnBack.TabIndex = 18;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnNext;
			this.btnNext.Location = new System.Drawing.Point(121, 1);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(25, 23);
			this.btnNext.TabIndex = 17;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
			this.panelMenu.ColumnCount = 9;
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.panelMenu.Controls.Add(this.btnPreview, 7, 0);
			this.panelMenu.Controls.Add(this.btnMode, 5, 0);
			this.panelMenu.Controls.Add(this.btnZoomIn, 0, 0);
			this.panelMenu.Controls.Add(this.btnOpen, 6, 0);
			this.panelMenu.Controls.Add(this.btnZoomOut, 1, 0);
			this.panelMenu.Controls.Add(this.btnFitToScreen, 2, 0);
			this.panelMenu.Controls.Add(this.btnRotate90, 4, 0);
			this.panelMenu.Controls.Add(this.btnRotate270, 3, 0);
			this.panelMenu.Controls.Add(this.cbZoom, 8, 0);
			this.panelMenu.Location = new System.Drawing.Point(3, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.RowCount = 1;
			this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panelMenu.Size = new System.Drawing.Size(411, 30);
			this.panelMenu.TabIndex = 14;
			// 
			// btnPreview
			// 
			this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnPreview.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnPreview;
			this.btnPreview.Location = new System.Drawing.Point(213, 3);
			this.btnPreview.Name = "btnPreview";
			this.btnPreview.Size = new System.Drawing.Size(24, 24);
			this.btnPreview.TabIndex = 15;
			this.toolTip.SetToolTip(this.btnPreview, "打开/关闭预览");
			this.btnPreview.UseVisualStyleBackColor = true;
			this.btnPreview.Visible = false;
			this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
			// 
			// btnMode
			// 
			this.btnMode.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnSelect;
			this.btnMode.Location = new System.Drawing.Point(153, 3);
			this.btnMode.Name = "btnMode";
			this.btnMode.Size = new System.Drawing.Size(24, 24);
			this.btnMode.TabIndex = 16;
			this.btnMode.UseVisualStyleBackColor = true;
			this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
			// 
			// btnZoomIn
			// 
			this.btnZoomIn.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnZoomIn;
			this.btnZoomIn.Location = new System.Drawing.Point(3, 3);
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.Size = new System.Drawing.Size(24, 24);
			this.btnZoomIn.TabIndex = 12;
			this.btnZoomIn.UseVisualStyleBackColor = true;
			this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnOpen;
			this.btnOpen.Location = new System.Drawing.Point(183, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(24, 24);
			this.btnOpen.TabIndex = 8;
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Visible = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnZoomOut
			// 
			this.btnZoomOut.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnZoomOut;
			this.btnZoomOut.Location = new System.Drawing.Point(33, 3);
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.Size = new System.Drawing.Size(24, 24);
			this.btnZoomOut.TabIndex = 11;
			this.btnZoomOut.UseVisualStyleBackColor = true;
			this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
			// 
			// btnFitToScreen
			// 
			this.btnFitToScreen.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnFitToScreen;
			this.btnFitToScreen.Location = new System.Drawing.Point(63, 3);
			this.btnFitToScreen.Name = "btnFitToScreen";
			this.btnFitToScreen.Size = new System.Drawing.Size(24, 24);
			this.btnFitToScreen.TabIndex = 13;
			this.btnFitToScreen.UseVisualStyleBackColor = true;
			this.btnFitToScreen.Click += new System.EventHandler(this.btnFitToScreen_Click);
			// 
			// btnRotate90
			// 
			this.btnRotate90.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnRotate90;
			this.btnRotate90.Location = new System.Drawing.Point(123, 3);
			this.btnRotate90.Name = "btnRotate90";
			this.btnRotate90.Size = new System.Drawing.Size(24, 23);
			this.btnRotate90.TabIndex = 9;
			this.btnRotate90.UseVisualStyleBackColor = true;
			this.btnRotate90.Click += new System.EventHandler(this.btnRotate90_Click);
			// 
			// btnRotate270
			// 
			this.btnRotate270.Image = global::Cnas.wns.CnasBaseUC.Properties.Resources.btnRotate270;
			this.btnRotate270.Location = new System.Drawing.Point(93, 3);
			this.btnRotate270.Name = "btnRotate270";
			this.btnRotate270.Size = new System.Drawing.Size(24, 24);
			this.btnRotate270.TabIndex = 10;
			this.btnRotate270.UseVisualStyleBackColor = true;
			this.btnRotate270.Click += new System.EventHandler(this.btnRotate270_Click);
			// 
			// pbPanel
			// 
			this.pbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbPanel.Location = new System.Drawing.Point(419, 33);
			this.pbPanel.Margin = new System.Windows.Forms.Padding(0);
			this.pbPanel.Name = "pbPanel";
			this.pbPanel.Size = new System.Drawing.Size(148, 108);
			this.pbPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPanel.TabIndex = 10;
			this.pbPanel.TabStop = false;
			this.pbPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPanel_MouseDown);
			this.pbPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPanel_MouseMove);
			this.pbPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPanel_MouseUp);
			// 
			// pbFull
			// 
			this.pbFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbFull.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pbFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbFull.Controls.Add(this.sbVert);
			this.pbFull.Controls.Add(this.sbHoriz);
			this.pbFull.Controls.Add(this.sbPanel);
			this.pbFull.Location = new System.Drawing.Point(2, 33);
			this.pbFull.Name = "pbFull";
			this.pbFull.Size = new System.Drawing.Size(412, 307);
			this.pbFull.TabIndex = 13;
			this.pbFull.Click += new System.EventHandler(this.pbFull_Click);
			this.pbFull.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbFull_DragDrop);
			this.pbFull.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbFull_DragEnter);
			this.pbFull.Paint += new System.Windows.Forms.PaintEventHandler(this.OnpbFullPaint);
			this.pbFull.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseDoubleClick);
			this.pbFull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseDown);
			this.pbFull.MouseEnter += new System.EventHandler(this.pbFull_MouseEnter);
			this.pbFull.MouseLeave += new System.EventHandler(this.pbFull_MouseLeave);
			this.pbFull.MouseHover += new System.EventHandler(this.pbFull_MouseHover);
			this.pbFull.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseMove);
			this.pbFull.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseUp);
			// 
			// sbVert
			// 
			this.sbVert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sbVert.Location = new System.Drawing.Point(393, 0);
			this.sbVert.Name = "sbVert";
			this.sbVert.Size = new System.Drawing.Size(17, 291);
			this.sbVert.TabIndex = 0;
			this.sbVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVert_Scroll);
			// 
			// sbHoriz
			// 
			this.sbHoriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sbHoriz.Location = new System.Drawing.Point(0, 290);
			this.sbHoriz.Name = "sbHoriz";
			this.sbHoriz.Size = new System.Drawing.Size(393, 17);
			this.sbHoriz.TabIndex = 1;
			this.sbHoriz.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbHoriz_Scroll);
			// 
			// sbPanel
			// 
			this.sbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sbPanel.BackColor = System.Drawing.SystemColors.Info;
			this.sbPanel.Location = new System.Drawing.Point(394, 291);
			this.sbPanel.Name = "sbPanel";
			this.sbPanel.Size = new System.Drawing.Size(16, 15);
			this.sbPanel.TabIndex = 2;
			// 
			// ImageViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.panelNavigation);
			this.Controls.Add(this.pbFull);
			this.Controls.Add(this.panelPreview);
			this.Controls.Add(this.pbPanel);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimumSize = new System.Drawing.Size(454, 145);
			this.Name = "ImageViewer";
			this.Size = new System.Drawing.Size(571, 343);
			this.Load += new System.EventHandler(this.OnImageViewerLoad);
			this.Click += new System.EventHandler(this.KpImageViewer_Click);
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.KP_ImageViewerV2_MouseWheel);
			this.Resize += new System.EventHandler(this.OnImageViewerResize);
			this.panelPreview.ResumeLayout(false);
			this.panelPreview.PerformLayout();
			this.panelNavigation.ResumeLayout(false);
			this.panelNavigation.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbPanel)).EndInit();
			this.pbFull.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPreview;
		private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox pbPanel;
        private PanelDoubleBuffered pbFull;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRotate270;
        private System.Windows.Forms.Button btnRotate90;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnFitToScreen;
        private System.Windows.Forms.ComboBox cbZoom;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.TextBox tbNavigation;
        private System.Windows.Forms.Panel sbPanel;
        private System.Windows.Forms.HScrollBar sbHoriz;
        private System.Windows.Forms.VScrollBar sbVert;
		private System.Windows.Forms.TableLayoutPanel panelMenu;
		private System.Windows.Forms.ToolTip toolTip;
    }
}
