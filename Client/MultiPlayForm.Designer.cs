namespace Client
{
    partial class MultiPlayForm
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
            this.boardPicture = new System.Windows.Forms.PictureBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPicture
            // 
            this.boardPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.boardPicture.Location = new System.Drawing.Point(12, 12);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(500, 500);
            this.boardPicture.TabIndex = 0;
            this.boardPicture.TabStop = false;
            this.boardPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture_Paint);
            this.boardPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown);
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(567, 85);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(80, 21);
            this.roomTextBox.TabIndex = 2;
            this.roomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(693, 19);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 40);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "접속하기";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(693, 66);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "게임 시작";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(521, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(272, 15);
            this.status.TabIndex = 5;
            this.status.Text = "방을 입력하여 접속해주세요.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(567, 19);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(80, 21);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "127.0.0.1";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(567, 52);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(80, 21);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(520, 22);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(45, 12);
            this.ip.TabIndex = 8;
            this.ip.Text = "Ip:";
            this.ip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(520, 55);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(45, 12);
            this.port.TabIndex = 7;
            this.port.Text = "Port:";
            this.port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(521, 88);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(45, 12);
            this.room.TabIndex = 6;
            this.room.Text = "Room:";
            this.room.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MultiPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.room);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.boardPicture);
            this.Name = "MultiPlayForm";
            this.Text = "MultiPlayForm";
            this.Load += new System.EventHandler(this.MultiPlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPicture;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Label room;
    }
}