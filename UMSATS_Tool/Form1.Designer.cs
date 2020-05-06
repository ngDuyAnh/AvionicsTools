namespace UMSATS_Tool
{
    partial class AvionicsTools
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvionicsTools));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_TabButton = new System.Windows.Forms.Panel();
            this.DataTab_Button = new System.Windows.Forms.Button();
            this.ConfigurationTab_Button = new System.Windows.Forms.Button();
            this.SerialTab_Button = new System.Windows.Forms.Button();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PortSelect_comboBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SerialPanel = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.SerialConnect_Button = new System.Windows.Forms.Button();
            this.SerialDisconnect_Button = new System.Windows.Forms.Button();
            this.BaudRate_TextBox = new System.Windows.Forms.TextBox();
            this.PortSetup_Label = new System.Windows.Forms.Label();
            this.BaudRate_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_TabButton.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_TabButton
            // 
            this.Panel_TabButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel_TabButton.Controls.Add(this.DataTab_Button);
            this.Panel_TabButton.Controls.Add(this.ConfigurationTab_Button);
            this.Panel_TabButton.Controls.Add(this.SerialTab_Button);
            this.Panel_TabButton.Location = new System.Drawing.Point(68, 12);
            this.Panel_TabButton.Name = "Panel_TabButton";
            this.Panel_TabButton.Size = new System.Drawing.Size(720, 73);
            this.Panel_TabButton.TabIndex = 2;
            // 
            // DataTab_Button
            // 
            this.DataTab_Button.Location = new System.Drawing.Point(494, 28);
            this.DataTab_Button.Name = "DataTab_Button";
            this.DataTab_Button.Size = new System.Drawing.Size(170, 23);
            this.DataTab_Button.TabIndex = 2;
            this.DataTab_Button.Text = "Data Graph/Plot";
            this.DataTab_Button.UseVisualStyleBackColor = false;
            this.DataTab_Button.Click += new System.EventHandler(this.DataTab_Button_Click);
            // 
            // ConfigurationTab_Button
            // 
            this.ConfigurationTab_Button.Location = new System.Drawing.Point(266, 28);
            this.ConfigurationTab_Button.Name = "ConfigurationTab_Button";
            this.ConfigurationTab_Button.Size = new System.Drawing.Size(170, 23);
            this.ConfigurationTab_Button.TabIndex = 1;
            this.ConfigurationTab_Button.Text = "Configuration";
            this.ConfigurationTab_Button.UseVisualStyleBackColor = false;
            this.ConfigurationTab_Button.Click += new System.EventHandler(this.ConfigurationTab_Click);
            // 
            // SerialTab_Button
            // 
            this.SerialTab_Button.Location = new System.Drawing.Point(42, 28);
            this.SerialTab_Button.Name = "SerialTab_Button";
            this.SerialTab_Button.Size = new System.Drawing.Size(170, 23);
            this.SerialTab_Button.TabIndex = 0;
            this.SerialTab_Button.Text = "Serial Communication";
            this.SerialTab_Button.UseVisualStyleBackColor = false;
            this.SerialTab_Button.Click += new System.EventHandler(this.SerialTab_Click);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.Controls.Add(this.SerialPanel);
            this.ConfigPanel.Controls.Add(this.panel1);
            this.ConfigPanel.Controls.Add(this.CloseButton);
            this.ConfigPanel.Location = new System.Drawing.Point(12, 91);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(776, 356);
            this.ConfigPanel.TabIndex = 3;
            this.ConfigPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BaudRate_Label);
            this.panel1.Controls.Add(this.PortSetup_Label);
            this.panel1.Controls.Add(this.BaudRate_TextBox);
            this.panel1.Controls.Add(this.SerialDisconnect_Button);
            this.panel1.Controls.Add(this.SerialConnect_Button);
            this.panel1.Controls.Add(this.PortSelect_comboBox);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 73);
            this.panel1.TabIndex = 1;
            // 
            // PortSelect_comboBox
            // 
            this.PortSelect_comboBox.FormattingEnabled = true;
            this.PortSelect_comboBox.Location = new System.Drawing.Point(3, 18);
            this.PortSelect_comboBox.Name = "PortSelect_comboBox";
            this.PortSelect_comboBox.Size = new System.Drawing.Size(94, 21);
            this.PortSelect_comboBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.No;
            this.CloseButton.Location = new System.Drawing.Point(701, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SerialPanel
            // 
            this.SerialPanel.Location = new System.Drawing.Point(0, 0);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(776, 356);
            this.SerialPanel.TabIndex = 4;
            this.SerialPanel.Visible = false;
            // 
            // DataPanel
            // 
            this.DataPanel.Location = new System.Drawing.Point(12, 91);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(776, 356);
            this.DataPanel.TabIndex = 4;
            // 
            // SerialConnect_Button
            // 
            this.SerialConnect_Button.Location = new System.Drawing.Point(103, 18);
            this.SerialConnect_Button.Name = "SerialConnect_Button";
            this.SerialConnect_Button.Size = new System.Drawing.Size(75, 23);
            this.SerialConnect_Button.TabIndex = 2;
            this.SerialConnect_Button.Text = "Connect";
            this.SerialConnect_Button.UseVisualStyleBackColor = true;
            this.SerialConnect_Button.Click += new System.EventHandler(this.SerialConnect_Button_Click);
            // 
            // SerialDisconnect_Button
            // 
            this.SerialDisconnect_Button.Location = new System.Drawing.Point(184, 18);
            this.SerialDisconnect_Button.Name = "SerialDisconnect_Button";
            this.SerialDisconnect_Button.Size = new System.Drawing.Size(75, 23);
            this.SerialDisconnect_Button.TabIndex = 3;
            this.SerialDisconnect_Button.Text = "Disconnect";
            this.SerialDisconnect_Button.UseVisualStyleBackColor = true;
            this.SerialDisconnect_Button.Click += new System.EventHandler(this.SerialDisconnect_Button_Click);
            // 
            // BaudRate_TextBox
            // 
            this.BaudRate_TextBox.Location = new System.Drawing.Point(62, 45);
            this.BaudRate_TextBox.Name = "BaudRate_TextBox";
            this.BaudRate_TextBox.Size = new System.Drawing.Size(70, 20);
            this.BaudRate_TextBox.TabIndex = 5;
            this.BaudRate_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PortSetup_Label
            // 
            this.PortSetup_Label.AutoSize = true;
            this.PortSetup_Label.Location = new System.Drawing.Point(0, 2);
            this.PortSetup_Label.Name = "PortSetup_Label";
            this.PortSetup_Label.Size = new System.Drawing.Size(60, 13);
            this.PortSetup_Label.TabIndex = 6;
            this.PortSetup_Label.Text = "Port Setup:";
            // 
            // BaudRate_Label
            // 
            this.BaudRate_Label.AutoSize = true;
            this.BaudRate_Label.Location = new System.Drawing.Point(3, 48);
            this.BaudRate_Label.Name = "BaudRate_Label";
            this.BaudRate_Label.Size = new System.Drawing.Size(61, 13);
            this.BaudRate_Label.TabIndex = 7;
            this.BaudRate_Label.Text = "Baud Rate:";
            // 
            // AvionicsTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_TabButton);
            this.Controls.Add(this.ConfigPanel);
            this.Controls.Add(this.DataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvionicsTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMSATS - Avionics Tools";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_TabButton.ResumeLayout(false);
            this.ConfigPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_TabButton;
        private System.Windows.Forms.Button SerialTab_Button;
        private System.Windows.Forms.Button DataTab_Button;
        private System.Windows.Forms.Button ConfigurationTab_Button;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SerialPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox PortSelect_comboBox;
        private System.Windows.Forms.Button SerialDisconnect_Button;
        private System.Windows.Forms.Button SerialConnect_Button;
        private System.Windows.Forms.TextBox BaudRate_TextBox;
        private System.Windows.Forms.Label PortSetup_Label;
        private System.Windows.Forms.Label BaudRate_Label;
    }
}

