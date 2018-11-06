namespace Control_Client
{
    partial class Form1
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
            this.btLogoff = new System.Windows.Forms.Button();
            this.btLock = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.btShutdown = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLogoff
            // 
            this.btLogoff.Location = new System.Drawing.Point(329, 92);
            this.btLogoff.Name = "btLogoff";
            this.btLogoff.Size = new System.Drawing.Size(85, 67);
            this.btLogoff.TabIndex = 15;
            this.btLogoff.Text = "Log Off";
            this.btLogoff.UseVisualStyleBackColor = true;
            this.btLogoff.Click += new System.EventHandler(this.btLogoff_Click);
            // 
            // btLock
            // 
            this.btLock.Location = new System.Drawing.Point(238, 92);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(85, 67);
            this.btLock.TabIndex = 17;
            this.btLock.Text = "Lock";
            this.btLock.UseVisualStyleBackColor = true;
            this.btLock.Click += new System.EventHandler(this.btLock_Click);
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(147, 92);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(85, 67);
            this.btRestart.TabIndex = 18;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btShutdown
            // 
            this.btShutdown.Location = new System.Drawing.Point(56, 92);
            this.btShutdown.Name = "btShutdown";
            this.btShutdown.Size = new System.Drawing.Size(85, 67);
            this.btShutdown.TabIndex = 19;
            this.btShutdown.Text = "ShutDown";
            this.btShutdown.UseVisualStyleBackColor = true;
            this.btShutdown.Click += new System.EventHandler(this.btShutdown_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(276, 42);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 16;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(369, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Cưỡng Chế";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(95, 42);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(158, 20);
            this.txtIP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 198);
            this.Controls.Add(this.btLogoff);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btShutdown);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogoff;
        private System.Windows.Forms.Button btLock;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btShutdown;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
    }
}

