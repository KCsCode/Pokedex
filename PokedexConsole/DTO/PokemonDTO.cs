namespace PokedexConsole.DTO
{
    public partial class PokemonDTO
    {
        public string Identifier { get; set; }
        public long? SpeciesId { get; set; }
        public long Height { get; set; }
        public long Weight { get; set; }
        public long BaseExperience { get; set; }
        
    }
}
