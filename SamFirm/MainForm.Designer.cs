﻿using System.Windows.Forms;

namespace SamFirm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.binary_checkbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.region_textbox = new System.Windows.Forms.TextBox();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.download_button = new System.Windows.Forms.Button();
            this.autoDecrypt_checkbox = new System.Windows.Forms.CheckBox();
            this.version_textbox = new System.Windows.Forms.TextBox();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.log_textbox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size_label);
            this.groupBox1.Controls.Add(this.update_button);
            this.groupBox1.Controls.Add(this.binary_checkbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.speed_label);
            this.groupBox1.Controls.Add(this.region_textbox);
            this.groupBox1.Controls.Add(this.model_textbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firmware Info";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(48, 138);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(42, 20);
            this.size_label.TabIndex = 13;
            this.size_label.Text = "0 GB";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(146, 96);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(124, 30);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Update Check";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // binary_checkbox
            // 
            this.binary_checkbox.AutoSize = true;
            this.binary_checkbox.Location = new System.Drawing.Point(10, 100);
            this.binary_checkbox.Name = "binary_checkbox";
            this.binary_checkbox.Size = new System.Drawing.Size(124, 24);
            this.binary_checkbox.TabIndex = 2;
            this.binary_checkbox.Text = "Binary Nature";
            this.binary_checkbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Size";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(197, 138);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(52, 20);
            this.speed_label.TabIndex = 12;
            this.speed_label.Text = "0 KB/s";
            // 
            // region_textbox
            // 
            this.region_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.region_textbox.Location = new System.Drawing.Point(106, 59);
            this.region_textbox.Name = "region_textbox";
            this.region_textbox.Size = new System.Drawing.Size(162, 27);
            this.region_textbox.TabIndex = 1;
            // 
            // model_textbox
            // 
            this.model_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.model_textbox.Location = new System.Drawing.Point(106, 26);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(162, 27);
            this.model_textbox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.decrypt_button);
            this.groupBox3.Controls.Add(this.download_button);
            this.groupBox3.Controls.Add(this.autoDecrypt_checkbox);
            this.groupBox3.Controls.Add(this.version_textbox);
            this.groupBox3.Controls.Add(this.file_textbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(294, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 161);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(99, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 27);
            this.progressBar1.TabIndex = 10;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(215, 125);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(110, 30);
            this.decrypt_button.TabIndex = 1;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(99, 125);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(110, 30);
            this.download_button.TabIndex = 0;
            this.download_button.Text = "Download";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // autoDecrypt_checkbox
            // 
            this.autoDecrypt_checkbox.AutoSize = true;
            this.autoDecrypt_checkbox.Checked = true;
            this.autoDecrypt_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoDecrypt_checkbox.Location = new System.Drawing.Point(346, 129);
            this.autoDecrypt_checkbox.Name = "autoDecrypt_checkbox";
            this.autoDecrypt_checkbox.Size = new System.Drawing.Size(181, 24);
            this.autoDecrypt_checkbox.TabIndex = 2;
            this.autoDecrypt_checkbox.Text = "Decrypt Automatically";
            this.autoDecrypt_checkbox.UseVisualStyleBackColor = true;
            // 
            // version_textbox
            // 
            this.version_textbox.Location = new System.Drawing.Point(99, 59);
            this.version_textbox.Name = "version_textbox";
            this.version_textbox.ReadOnly = true;
            this.version_textbox.Size = new System.Drawing.Size(428, 27);
            this.version_textbox.TabIndex = 4;
            this.version_textbox.TabStop = false;
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(99, 26);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.ReadOnly = true;
            this.file_textbox.Size = new System.Drawing.Size(428, 27);
            this.file_textbox.TabIndex = 3;
            this.file_textbox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "File";
            // 
            // log_textbox
            // 
            this.log_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_textbox.Location = new System.Drawing.Point(12, 179);
            this.log_textbox.Name = "log_textbox";
            this.log_textbox.ReadOnly = true;
            this.log_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_textbox.Size = new System.Drawing.Size(821, 255);
            this.log_textbox.TabIndex = 2;
            this.log_textbox.TabStop = false;
            this.log_textbox.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.Filter = "All files|*.*";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.update_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.log_textbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SamFirm Continued";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //필드 (컨트롤)
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.CheckBox binary_checkbox;
        private System.Windows.Forms.CheckBox autoDecrypt_checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox log_textbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox region_textbox;
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.TextBox version_textbox;

        //Getter, Setter 메소드
        public RichTextBox Log_textbox { get => log_textbox; set => log_textbox = value; }
        public Label Speed_label { get => speed_label; set => speed_label = value; }
    }
}