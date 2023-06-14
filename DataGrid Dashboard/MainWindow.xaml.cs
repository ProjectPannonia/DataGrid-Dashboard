using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace DataGrid_Dashboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            // Create DataGrid Items Info
            members.Add(new Member { Number="1",   Character="J", BgColor=(Brush)converter.ConvertFromString("#1098ad"), Name="John Doe", Position="Coach", Email="john.doe@gmail.com", Phone="415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza.alavi@hotmail.com", Phone = "123-456-789" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Dennis Castillo", Position = "Coach", Email = "dennis.castillo@gmail.com", Phone = "232-111-245" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Gabriel Cox", Position = "Coach", Email = "gabriel.cox@hotmail.com", Phone = "932-435-657" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Lena Jones", Position = "Manager", Email = "lena.jones@hotmail.com", Phone = "123-234-564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Benjamin Caliword", Position = "Administrator", Email = "benjamin.caliword@gmail.com", Phone = "267-784-999" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ali Pormand", Position = "Coach", Email = "ali.pormand@gmail.com", Phone = "526-775-456" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Frank Underwood", Position = "Manager", Email = "frank.underwood@hotmail.com", Phone = "789-567-345" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Sophia Muris", Position = "Manager", Email = "sophia.muris@hotmail.com", Phone = "346-765-123" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasman@gmail.com", Phone = "435-765-322" });

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza.alavi@hotmail.com", Phone = "123-456-789" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Dennis Castillo", Position = "Coach", Email = "dennis.castillo@gmail.com", Phone = "232-111-245" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Gabriel Cox", Position = "Coach", Email = "gabriel.cox@hotmail.com", Phone = "932-435-657" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Lena Jones", Position = "Manager", Email = "lena.jones@hotmail.com", Phone = "123-234-564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Benjamin Caliword", Position = "Administrator", Email = "benjamin.caliword@gmail.com", Phone = "267-784-999" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ali Pormand", Position = "Coach", Email = "ali.pormand@gmail.com", Phone = "526-775-456" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Frank Underwood", Position = "Manager", Email = "frank.underwood@hotmail.com", Phone = "789-567-345" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Sophia Muris", Position = "Manager", Email = "sophia.muris@hotmail.com", Phone = "346-765-123" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasman@gmail.com", Phone = "435-765-322" });

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza.alavi@hotmail.com", Phone = "123-456-789" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Dennis Castillo", Position = "Coach", Email = "dennis.castillo@gmail.com", Phone = "232-111-245" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Gabriel Cox", Position = "Coach", Email = "gabriel.cox@hotmail.com", Phone = "932-435-657" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Lena Jones", Position = "Manager", Email = "lena.jones@hotmail.com", Phone = "123-234-564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Benjamin Caliword", Position = "Administrator", Email = "benjamin.caliword@gmail.com", Phone = "267-784-999" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ali Pormand", Position = "Coach", Email = "ali.pormand@gmail.com", Phone = "526-775-456" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Frank Underwood", Position = "Manager", Email = "frank.underwood@hotmail.com", Phone = "789-567-345" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Sophia Muris", Position = "Manager", Email = "sophia.muris@hotmail.com", Phone = "346-765-123" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasman@gmail.com", Phone = "435-765-322" });

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if(IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                } else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized= true;
                }
            }
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
