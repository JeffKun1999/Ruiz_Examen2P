namespace NotesJR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.NotePageJR), typeof(Views.NotePageJR));
        }
    }
}
