
namespace rock_paper_scissors
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
            this.labelText = new System.Windows.Forms.Label();
            this.labelBotChoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelMyChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(49, 182);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(168, 25);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Ход противника:";
            // 
            // labelBotChoice
            // 
            this.labelBotChoice.AutoSize = true;
            this.labelBotChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBotChoice.Location = new System.Drawing.Point(223, 186);
            this.labelBotChoice.Name = "labelBotChoice";
            this.labelBotChoice.Size = new System.Drawing.Size(58, 22);
            this.labelBotChoice.TabIndex = 1;
            this.labelBotChoice.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваш ход:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(227, 281);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(127, 66);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Играть!";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelMyChoice
            // 
            this.labelMyChoice.AutoSize = true;
            this.labelMyChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyChoice.Location = new System.Drawing.Point(198, 83);
            this.labelMyChoice.Name = "labelMyChoice";
            this.labelMyChoice.Size = new System.Drawing.Size(51, 20);
            this.labelMyChoice.TabIndex = 4;
            this.labelMyChoice.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 485);
            this.Controls.Add(this.labelMyChoice);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBotChoice);
            this.Controls.Add(this.labelText);
            this.Name = "Form1";
            this.Text = "Камень, Ножницы, Бумага";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelBotChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelMyChoice;
    }
}

