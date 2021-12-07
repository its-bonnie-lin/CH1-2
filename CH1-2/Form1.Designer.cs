namespace CH1_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFor = new System.Windows.Forms.RadioButton();
            this.rdbWhile = new System.Windows.Forms.RadioButton();
            this.rdbDo = new System.Windows.Forms.RadioButton();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "數值累加程式";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDo);
            this.groupBox1.Controls.Add(this.rdbWhile);
            this.groupBox1.Controls.Add(this.rdbFor);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(82, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "迴圈種類";
            // 
            // rdbFor
            // 
            this.rdbFor.AutoSize = true;
            this.rdbFor.Location = new System.Drawing.Point(43, 22);
            this.rdbFor.Name = "rdbFor";
            this.rdbFor.Size = new System.Drawing.Size(48, 23);
            this.rdbFor.TabIndex = 0;
            this.rdbFor.Text = "for";
            this.rdbFor.UseVisualStyleBackColor = true;
            // 
            // rdbWhile
            // 
            this.rdbWhile.AutoSize = true;
            this.rdbWhile.Location = new System.Drawing.Point(43, 63);
            this.rdbWhile.Name = "rdbWhile";
            this.rdbWhile.Size = new System.Drawing.Size(65, 23);
            this.rdbWhile.TabIndex = 1;
            this.rdbWhile.Text = "while";
            this.rdbWhile.UseVisualStyleBackColor = true;
            // 
            // rdbDo
            // 
            this.rdbDo.AutoSize = true;
            this.rdbDo.Checked = true;
            this.rdbDo.Location = new System.Drawing.Point(43, 101);
            this.rdbDo.Name = "rdbDo";
            this.rdbDo.Size = new System.Drawing.Size(97, 23);
            this.rdbDo.TabIndex = 2;
            this.rdbDo.TabStop = true;
            this.rdbDo.Text = "do...while";
            this.rdbDo.UseVisualStyleBackColor = true;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(523, 139);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 22);
            this.txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(523, 204);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 22);
            this.txtEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(441, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "起始值 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(441, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "終止值 : ";
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.ForeColor = System.Drawing.Color.Blue;
            this.btnCal.Location = new System.Drawing.Point(472, 259);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(118, 38);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "計算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(-1, 384);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(802, 72);
            this.lblShow.TabIndex = 7;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDo;
        private System.Windows.Forms.RadioButton rdbWhile;
        private System.Windows.Forms.RadioButton rdbFor;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblShow;
    }
}

