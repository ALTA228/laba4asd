namespace laba4asd
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInputArray = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtNodeVal = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTask23 = new System.Windows.Forms.Button();
            this.txtTreeView = new System.Windows.Forms.TextBox();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblNode = new System.Windows.Forms.Label();
            this.lblTree = new System.Windows.Forms.Label();
            this.lblTraversal = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputArray
            // 
            this.txtInputArray.Location = new System.Drawing.Point(20, 35);
            this.txtInputArray.Name = "txtInputArray";
            this.txtInputArray.Size = new System.Drawing.Size(340, 20);
            this.txtInputArray.TabIndex = 0;
            this.txtInputArray.Text = "50, 30, 70, 20, 40, 10, 25";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(370, 33);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(160, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Побудувати дерево";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtNodeVal
            // 
            this.txtNodeVal.Location = new System.Drawing.Point(20, 85);
            this.txtNodeVal.Name = "txtNodeVal";
            this.txtNodeVal.Size = new System.Drawing.Size(80, 20);
            this.txtNodeVal.TabIndex = 2;
            this.txtNodeVal.Text = "25";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(110, 83);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Додати";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(210, 83);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Знайти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTask23
            // 
            this.btnTask23.Location = new System.Drawing.Point(410, 83);
            this.btnTask23.Name = "btnTask23";
            this.btnTask23.Size = new System.Drawing.Size(120, 23);
            this.btnTask23.TabIndex = 6;
            this.btnTask23.Text = "Завдання (Вар. 23)";
            this.btnTask23.UseVisualStyleBackColor = true;
            this.btnTask23.Click += new System.EventHandler(this.btnTask23_Click);
            // 
            // txtTreeView
            // 
            this.txtTreeView.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtTreeView.Location = new System.Drawing.Point(20, 140);
            this.txtTreeView.Multiline = true;
            this.txtTreeView.Name = "txtTreeView";
            this.txtTreeView.ReadOnly = true;
            this.txtTreeView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTreeView.Size = new System.Drawing.Size(510, 160);
            this.txtTreeView.TabIndex = 7;
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(20, 330);
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.ReadOnly = true;
            this.txtPostOrder.Size = new System.Drawing.Size(510, 20);
            this.txtPostOrder.TabIndex = 8;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 380);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(510, 50);
            this.txtLog.TabIndex = 9;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(20, 15);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(218, 13);
            this.lblInit.Text = "Елементи дерева (через кому або пробіл):";
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.Location = new System.Drawing.Point(20, 65);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(107, 13);
            this.lblNode.Text = "Значення вершини:";
            // 
            // lblTree
            // 
            this.lblTree.AutoSize = true;
            this.lblTree.Location = new System.Drawing.Point(20, 120);
            this.lblTree.Name = "lblTree";
            this.lblTree.Size = new System.Drawing.Size(242, 13);
            this.lblTree.Text = "Структура дерева (повернута на 90° вліво):";
            // 
            // lblTraversal
            // 
            this.lblTraversal.AutoSize = true;
            this.lblTraversal.Location = new System.Drawing.Point(20, 310);
            this.lblTraversal.Name = "lblTraversal";
            this.lblTraversal.Size = new System.Drawing.Size(256, 13);
            this.lblTraversal.Text = "Зворотний обхід (PostOrder: Лівий-Правий-Корінь):";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(20, 360);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(113, 13);
            this.lblRes.Text = "Результат виконання:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblTraversal);
            this.Controls.Add(this.lblTree);
            this.Controls.Add(this.lblNode);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.txtTreeView);
            this.Controls.Add(this.btnTask23);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtNodeVal);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtInputArray);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №4 — Бінарні дерева";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInputArray;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.TextBox txtNodeVal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTask23;
        private System.Windows.Forms.TextBox txtTreeView;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.Label lblTree;
        private System.Windows.Forms.Label lblTraversal;
        private System.Windows.Forms.Label lblRes;
    }
}