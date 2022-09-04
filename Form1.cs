namespace Backpack
{
    public partial class Form1 : Form
    {
        private List<Item> items;

        public Form1()
        {
            InitializeComponent();

            AddItems();
            ShowItems(items);
        }

        //�������� ��������
        private void AddItems()
        {
            items = new List<Item>();

            items.Add(new Item("������", 3, 40));
            items.Add(new Item("�������", 3, 50));
            items.Add(new Item("�����", 5, 60));
            items.Add(new Item("����", 12, 100));
            items.Add(new Item("�������", 18, 200));
        }

        //�������� �������� ������
        private void ShowItems(List<Item> _items)
        {
            itemsListView.Items.Clear();
            foreach (Item item in _items)
            {
                itemsListView.Items.Add(new ListViewItem(new string[] { item.name, item.weigth.ToString(),
                    item.price.ToString() }));
            }
        }

        //�������� �������� ������ ��� ������� �� ������
        private void ShowConditionsButton_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }


        //������ ������
        private void SolveTask()
        {
            try
            {
                Backpack bp = new Backpack(Convert.ToDouble(weightTextBox.Text));
                bp.MakeAllSets(items);
                List<Item> solve = bp.GetBestSet();
                if (solve == null)
                {
                    MessageBox.Show("��� �������!");
                }
                else
                {
                    itemsListView.Items.Clear();

                    ShowItems(solve);

                    MessageBox.Show("������� ��������� � �������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
        }
        //������ ������
        private void solveButton_Click(object sender, EventArgs e)
        {
            SolveTask();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolveTask();
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}