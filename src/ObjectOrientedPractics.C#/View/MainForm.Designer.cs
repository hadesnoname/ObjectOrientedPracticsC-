namespace ObjectOrientedPractics.C_
{
    partial class MainForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.itemsTab1 = new ObjectOrientedPractics.C_.View.Tabs.ItemsTab();
            this.customers1 = new ObjectOrientedPractics.C_.View.Tabs.Customers();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customers1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1314, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.itemsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1314, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1322, 621);
            this.tabPage.TabIndex = 0;
            this.tabPage.Tag = "";
            // 
            // itemsTab1
            // 
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(962, 588);
            this.itemsTab1.TabIndex = 0;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(0, -2);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(962, 588);
            this.customers1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 621);
            this.Controls.Add(this.tabPage);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabPage;
        private View.Tabs.Customers customers1;
        private View.Tabs.ItemsTab itemsTab1;
    }
}

