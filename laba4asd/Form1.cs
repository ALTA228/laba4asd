using System;
using System.Windows.Forms;

namespace laba4asd
{
    public partial class Form1 : Form
    {
        private BinaryTree tree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDisplay()
        {
            txtTreeView.Text = tree.PrintTreeStructure();
            txtPostOrder.Text = tree.PostOrderTraversal();
        }

        // Сформувати дерево з рядка чисел
        private void btnBuild_Click(object sender, EventArgs e)
        {
            tree.Clear();
            string[] parts = txtInputArray.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int val))
                {
                    tree.Insert(val);
                }
            }
            UpdateDisplay();
            txtLog.Text = "Бінарне дерево успішно сформовано.";
        }

        // Додати одну вершину
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeVal.Text, out int val))
            {
                tree.Insert(val);
                UpdateDisplay();
                txtLog.Text = $"Вершину [{val}] додано в дерево.";
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число!");
            }
        }

        // Знайти вершину
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeVal.Text, out int val))
            {
                bool found = tree.Find(val);
                txtLog.Text = found
                    ? $"Вершина [{val}] ЗНАЙДЕНА у дереві."
                    : $"Вершина [{val}] ВІДСУТНЯ у дереві.";
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число!");
            }
        }

        // Видалити вершину
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodeVal.Text, out int val))
            {
                tree.Delete(val);
                UpdateDisplay();
                txtLog.Text = $"Операцію видалення вершини [{val}] виконано.";
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число!");
            }
        }

        // Індивідуальне завдання (Варіант 23)
        private void btnTask23_Click(object sender, EventArgs e)
        {
            txtLog.Text = tree.FindRightLeafOfLeftmostParent();
        }
    }
}