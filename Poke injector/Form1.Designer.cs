namespace Poke_injector
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.peek = new System.Windows.Forms.Button();
            this.poke = new System.Windows.Forms.Button();
            this.ramAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.switchip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // peek
            // 
            this.peek.Location = new System.Drawing.Point(12, 344);
            this.peek.Name = "peek";
            this.peek.Size = new System.Drawing.Size(169, 44);
            this.peek.TabIndex = 0;
            this.peek.Text = "Peek Address";
            this.peek.UseVisualStyleBackColor = true;
            // 
            // poke
            // 
            this.poke.Location = new System.Drawing.Point(12, 394);
            this.poke.Name = "poke";
            this.poke.Size = new System.Drawing.Size(169, 44);
            this.poke.TabIndex = 1;
            this.poke.Text = "Poke Address";
            this.poke.UseVisualStyleBackColor = true;
            // 
            // ramAddress
            // 
            this.ramAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramAddress.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.ramAddress.Location = new System.Drawing.Point(12, 27);
            this.ramAddress.Name = "ramAddress";
            this.ramAddress.Size = new System.Drawing.Size(117, 20);
            this.ramAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ram Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Switch IP";
            // 
            // switchip
            // 
            this.switchip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.switchip.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.switchip.Location = new System.Drawing.Point(12, 76);
            this.switchip.Name = "switchip";
            this.switchip.Size = new System.Drawing.Size(117, 20);
            this.switchip.TabIndex = 5;
            this.switchip.Text = "192.168.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ram Size";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.textBox2.Location = new System.Drawing.Point(12, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.switchip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramAddress);
            this.Controls.Add(this.poke);
            this.Controls.Add(this.peek);
            this.Name = "Form1";
            this.Text = "Switch Ram Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button peek;
        private System.Windows.Forms.Button poke;
        private System.Windows.Forms.TextBox ramAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox switchip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

