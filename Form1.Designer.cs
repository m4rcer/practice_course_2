namespace practice_course_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.maxSquareBtn = new System.Windows.Forms.Button();
            this.minPopulationBtn = new System.Windows.Forms.Button();
            this.avgPopulationBtn = new System.Windows.Forms.Button();
            this.deleteDtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.square,
            this.population});
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // square
            // 
            this.square.HeaderText = "Площадь (кв.км)";
            this.square.MinimumWidth = 8;
            this.square.Name = "square";
            this.square.Width = 150;
            // 
            // population
            // 
            this.population.HeaderText = "Население (тыс. чел.)";
            this.population.MinimumWidth = 8;
            this.population.Name = "population";
            this.population.Width = 150;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1069, 32);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(245, 61);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.Location = new System.Drawing.Point(277, 538);
            this.allBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(148, 61);
            this.allBtn.TabIndex = 2;
            this.allBtn.Text = "Все";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(25, 538);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(245, 61);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(25, 486);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 35);
            this.nameTextBox.TabIndex = 4;
            // 
            // maxSquareBtn
            // 
            this.maxSquareBtn.Location = new System.Drawing.Point(432, 538);
            this.maxSquareBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxSquareBtn.Name = "maxSquareBtn";
            this.maxSquareBtn.Size = new System.Drawing.Size(245, 61);
            this.maxSquareBtn.TabIndex = 5;
            this.maxSquareBtn.Text = "Максимальная площадь";
            this.maxSquareBtn.UseVisualStyleBackColor = true;
            this.maxSquareBtn.Click += new System.EventHandler(this.maxSquareBtn_Click);
            // 
            // minPopulationBtn
            // 
            this.minPopulationBtn.Location = new System.Drawing.Point(684, 538);
            this.minPopulationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minPopulationBtn.Name = "minPopulationBtn";
            this.minPopulationBtn.Size = new System.Drawing.Size(245, 61);
            this.minPopulationBtn.TabIndex = 6;
            this.minPopulationBtn.Text = "Максимальное население";
            this.minPopulationBtn.UseVisualStyleBackColor = true;
            this.minPopulationBtn.Click += new System.EventHandler(this.minPopulationBtn_Click);
            // 
            // avgPopulationBtn
            // 
            this.avgPopulationBtn.Location = new System.Drawing.Point(936, 538);
            this.avgPopulationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avgPopulationBtn.Name = "avgPopulationBtn";
            this.avgPopulationBtn.Size = new System.Drawing.Size(245, 61);
            this.avgPopulationBtn.TabIndex = 7;
            this.avgPopulationBtn.Text = "Среднее население";
            this.avgPopulationBtn.UseVisualStyleBackColor = true;
            this.avgPopulationBtn.Click += new System.EventHandler(this.avgPopulationBtn_Click);
            // 
            // deleteDtn
            // 
            this.deleteDtn.Location = new System.Drawing.Point(1069, 230);
            this.deleteDtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteDtn.Name = "deleteDtn";
            this.deleteDtn.Size = new System.Drawing.Size(245, 61);
            this.deleteDtn.TabIndex = 8;
            this.deleteDtn.Text = "Удалить";
            this.deleteDtn.UseVisualStyleBackColor = true;
            this.deleteDtn.Click += new System.EventHandler(this.deleteDtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(1069, 126);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(245, 61);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Редактировать";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 666);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteDtn);
            this.Controls.Add(this.avgPopulationBtn);
            this.Controls.Add(this.minPopulationBtn);
            this.Controls.Add(this.maxSquareBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn square;
        private System.Windows.Forms.DataGridViewTextBoxColumn population;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button maxSquareBtn;
        private System.Windows.Forms.Button minPopulationBtn;
        private System.Windows.Forms.Button avgPopulationBtn;
        private System.Windows.Forms.Button deleteDtn;
        private System.Windows.Forms.Button updateBtn;
    }
}

