using System;
using System.Collections.Generic;

namespace laba4asd
{
    public class TreeNode
    {
        public int Data;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode? Root;

        public BinaryTree()
        {
            Root = null;
        }

        // 1. Вставка вершини в бінарне дерево пошуку (BST)
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private TreeNode InsertRec(TreeNode? root, int data)
        {
            if (root == null)
            {
                return new TreeNode(data);
            }

            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        // 2. Пошук вершини в дереві
        public bool Find(int data)
        {
            return FindRec(Root, data);
        }

        private bool FindRec(TreeNode? root, int data)
        {
            if (root == null) return false;
            if (root.Data == data) return true;
            if (data < root.Data) return FindRec(root.Left, data);
            return FindRec(root.Right, data);
        }

        // 3. Видалення вершини з дерева
        public void Delete(int data)
        {
            Root = DeleteRec(Root, data);
        }

        private TreeNode? DeleteRec(TreeNode? root, int data)
        {
            if (root == null) return null;

            if (data < root.Data)
                root.Left = DeleteRec(root.Left, data);
            else if (data > root.Data)
                root.Right = DeleteRec(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Data);
            }
            return root;
        }

        private int MinValue(TreeNode root)
        {
            int minv = root.Data;
            while (root.Left != null)
            {
                minv = root.Left.Data;
                root = root.Left;
            }
            return minv;
        }

        // 4. Зворотний обхід (PostOrder: Лівий -> Правий -> Корінь) за варіантом 23
        public string PostOrderTraversal()
        {
            List<int> result = new List<int>();
            PostOrderRec(Root, result);
            return result.Count > 0 ? string.Join(" -> ", result) : "Дерево порожнє";
        }

        private void PostOrderRec(TreeNode? node, List<int> list)
        {
            if (node != null)
            {
                PostOrderRec(node.Left, list);
                PostOrderRec(node.Right, list);
                list.Add(node.Data);
            }
        }

        // 5. Індивідуальне завдання (Варіант 23):
        // Вивести правий лист самого лівого вузла-батька дерева
        public string FindRightLeafOfLeftmostParent()
        {
            if (Root == null)
                return "Дерево порожнє.";

            TreeNode? current = Root;
            TreeNode? leftmostParent = null;

            while (current != null)
            {
                if (current.Left != null || current.Right != null)
                {
                    leftmostParent = current;
                }

                if (current.Left != null)
                    current = current.Left;
                else
                    break;
            }

            if (leftmostParent == null)
                return "У дереві немає вузлів-батьків (лише корінь).";

            if (leftmostParent.Right != null)
            {
                if (leftmostParent.Right.Left == null && leftmostParent.Right.Right == null)
                    return $"Найлівіший вузол-батько: {leftmostParent.Data}. Його правий лист: {leftmostParent.Right.Data}";
                else
                    return $"Найлівіший вузол-батько: {leftmostParent.Data}, але його правий нащадок ({leftmostParent.Right.Data}) не є листом (має власних нащадків).";
            }
            else
            {
                return $"Найлівіший вузол-батько: {leftmostParent.Data}, але у нього відсутній правий лист.";
            }
        }

        // 6. Візуалізація структури дерева у вигляді тексту
        public string PrintTreeStructure()
        {
            if (Root == null) return "Дерево порожнє.";
            List<string> lines = new List<string>();
            PrintTreeRec(Root, 0, lines);
            return string.Join("\r\n", lines);
        }

        private void PrintTreeRec(TreeNode? node, int level, List<string> lines)
        {
            if (node != null)
            {
                PrintTreeRec(node.Right, level + 1, lines);
                lines.Add(new string(' ', level * 6) + $"[{node.Data}]");
                PrintTreeRec(node.Left, level + 1, lines);
            }
        }

        // 7. Очищення дерева
        public void Clear()
        {
            Root = null;
        }
    }
}