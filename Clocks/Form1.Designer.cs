namespace Clocks
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClockTimer = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ClockTimer
            // 
            this.ClockTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClockTimer.Font = new System.Drawing.Font("Umpqua", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClockTimer.Location = new System.Drawing.Point(0, 1);
            this.ClockTimer.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ClockTimer.MinimumSize = new System.Drawing.Size(120, 80);
            this.ClockTimer.Name = "ClockTimer";
            this.ClockTimer.Size = new System.Drawing.Size(377, 199);
            this.ClockTimer.TabIndex = 0;
            this.ClockTimer.Text = "HH:mm:ss";
            this.ClockTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockTimer.UseMnemonic = false;
            this.ClockTimer.MarginChanged += new System.EventHandler(this.ClockTimer_MarginChanged);
            this.ClockTimer.Click += new System.EventHandler(this.ClockTimer_Click);
            this.ClockTimer.DoubleClick += new System.EventHandler(this.ClockTimer_DoubleClick);
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.ClockTimer);
            this.Font = new System.Drawing.Font("Umpqua", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(120, 80);
            this.Name = "Form1";
            this.Text = "CLOCK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Label ClockTimer;
    }
}

