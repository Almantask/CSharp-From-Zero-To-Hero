namespace BootCamp.Chapter.Mediator
{
    public interface ITile
    {
        bool IsColored { get; }
        void Toggle();
    }

    public class Tile : ITile
    {
        public bool IsColored { private set; get; }
        private readonly IColorAllGame _game;

        public Tile(bool isColored, IColorAllGame game)
        {
            IsColored = isColored;
            _game = game;
        }

        public void Toggle()
        {
            IsColored = !IsColored;
            _game.IsComplete();
        } 
    }
}
