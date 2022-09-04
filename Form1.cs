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

        //добавить предметы
        private void AddItems()
        {
            items = new List<Item>();

            items.Add(new Item("Кольцо", 3, 40));
            items.Add(new Item("Картина", 3, 50));
            items.Add(new Item("Плита", 5, 60));
            items.Add(new Item("Плащ", 12, 100));
            items.Add(new Item("Ноутбук", 18, 200));
        }

        //показать исходные данные
        private void ShowItems(List<Item> _items)
        {
            itemsListView.Items.Clear();
            foreach (Item item in _items)
            {
                itemsListView.Items.Add(new ListViewItem(new string[] { item.name, item.weigth.ToString(),
                    item.price.ToString() }));
            }
        }

        //показать исходные данные при нажатии на кнопку
        private void ShowConditionsButton_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }


        //решить задачу
        private void SolveTask()
        {
            try
            {
                Backpack bp = new Backpack(Convert.ToDouble(weightTextBox.Text));
                bp.MakeAllSets(items);
                List<Item> solve = bp.GetBestSet();
                if (solve == null)
                {
                    MessageBox.Show("Нет решения!");
                }
                else
                {
                    itemsListView.Items.Clear();

                    ShowItems(solve);

                    MessageBox.Show("Решение приведено в таблице");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
        }
        //решить задачу
        private void solveButton_Click(object sender, EventArgs e)
        {
            SolveTask();
        }

        private void решитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolveTask();
        }

        private void показатьИсходныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowItems(items);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}