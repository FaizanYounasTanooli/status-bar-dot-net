namespace Status_Bar_Namespace
{
    partial class Status_Bar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLP_Status_Bar = new System.Windows.Forms.TableLayoutPanel();
            this.L_Ready = new System.Windows.Forms.Label();
            this.L_Notification_Text = new System.Windows.Forms.Label();
            this.LCopyRightText = new System.Windows.Forms.Label();
            this.TLP_Status_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Status_Bar
            // 
            this.TLP_Status_Bar.ColumnCount = 2;
            this.TLP_Status_Bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Status_Bar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Status_Bar.Controls.Add(this.L_Ready, 0, 0);
            this.TLP_Status_Bar.Controls.Add(this.L_Notification_Text, 0, 1);
            this.TLP_Status_Bar.Controls.Add(this.LCopyRightText, 1, 0);
            this.TLP_Status_Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Status_Bar.Location = new System.Drawing.Point(0, 0);
            this.TLP_Status_Bar.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Status_Bar.Name = "TLP_Status_Bar";
            this.TLP_Status_Bar.RowCount = 2;
            this.TLP_Status_Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLP_Status_Bar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TLP_Status_Bar.Size = new System.Drawing.Size(778, 33);
            this.TLP_Status_Bar.TabIndex = 15;
            // 
            // L_Ready
            // 
            this.L_Ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.L_Ready.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_Ready.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ready.ForeColor = System.Drawing.Color.White;
            this.L_Ready.Location = new System.Drawing.Point(0, 0);
            this.L_Ready.Margin = new System.Windows.Forms.Padding(0);
            this.L_Ready.Name = "L_Ready";
            this.L_Ready.Size = new System.Drawing.Size(72, 15);
            this.L_Ready.TabIndex = 0;
            this.L_Ready.Text = "Ready";
            this.L_Ready.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_Notification_Text
            // 
            this.L_Notification_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TLP_Status_Bar.SetColumnSpan(this.L_Notification_Text, 2);
            this.L_Notification_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_Notification_Text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Notification_Text.ForeColor = System.Drawing.Color.White;
            this.L_Notification_Text.Location = new System.Drawing.Point(0, 15);
            this.L_Notification_Text.Margin = new System.Windows.Forms.Padding(0);
            this.L_Notification_Text.Name = "L_Notification_Text";
            this.L_Notification_Text.Size = new System.Drawing.Size(778, 18);
            this.L_Notification_Text.TabIndex = 1;
            this.L_Notification_Text.Text = "Ready";
            this.L_Notification_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCopyRightText
            // 
            this.LCopyRightText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LCopyRightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCopyRightText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCopyRightText.ForeColor = System.Drawing.Color.Black;
            this.LCopyRightText.Location = new System.Drawing.Point(72, 0);
            this.LCopyRightText.Margin = new System.Windows.Forms.Padding(0);
            this.LCopyRightText.Name = "LCopyRightText";
            this.LCopyRightText.Size = new System.Drawing.Size(706, 15);
            this.LCopyRightText.TabIndex = 0;
            this.LCopyRightText.Text = "Copyright© GPS 2020";
            this.LCopyRightText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Status_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP_Status_Bar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Status_Bar";
            this.Size = new System.Drawing.Size(778, 33);
            this.TLP_Status_Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Status_Bar;
        private System.Windows.Forms.Label L_Ready;
        private System.Windows.Forms.Label L_Notification_Text;
        private System.Windows.Forms.Label LCopyRightText;
    }
}
