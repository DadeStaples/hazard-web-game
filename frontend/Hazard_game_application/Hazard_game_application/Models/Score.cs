namespace Hazard_game_application.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public string Result { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

