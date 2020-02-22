using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace PokedexConsole.Entities
{
    public partial class PokedexContext : DbContext
    {
        public PokedexContext()
        {
        }

        public PokedexContext(DbContextOptions<PokedexContext> options)
            : base(options)
        {
        }

        #region DbSet
        public virtual DbSet<Abilities> Abilities { get; set; }
        public virtual DbSet<AbilityChangelog> AbilityChangelog { get; set; }
        public virtual DbSet<AbilityChangelogProse> AbilityChangelogProse { get; set; }
        public virtual DbSet<AbilityFlavorText> AbilityFlavorText { get; set; }
        public virtual DbSet<AbilityNames> AbilityNames { get; set; }
        public virtual DbSet<AbilityProse> AbilityProse { get; set; }
        public virtual DbSet<Berries> Berries { get; set; }
        public virtual DbSet<BerryFirmness> BerryFirmness { get; set; }
        public virtual DbSet<BerryFirmnessNames> BerryFirmnessNames { get; set; }
        public virtual DbSet<BerryFlavors> BerryFlavors { get; set; }
        public virtual DbSet<CharacteristicText> CharacteristicText { get; set; }
        public virtual DbSet<Characteristics> Characteristics { get; set; }
        public virtual DbSet<ConquestEpisodeNames> ConquestEpisodeNames { get; set; }
        public virtual DbSet<ConquestEpisodeWarriors> ConquestEpisodeWarriors { get; set; }
        public virtual DbSet<ConquestEpisodes> ConquestEpisodes { get; set; }
        public virtual DbSet<ConquestKingdomNames> ConquestKingdomNames { get; set; }
        public virtual DbSet<ConquestKingdoms> ConquestKingdoms { get; set; }
        public virtual DbSet<ConquestMaxLinks> ConquestMaxLinks { get; set; }
        public virtual DbSet<ConquestMoveData> ConquestMoveData { get; set; }
        public virtual DbSet<ConquestMoveDisplacementProse> ConquestMoveDisplacementProse { get; set; }
        public virtual DbSet<ConquestMoveDisplacements> ConquestMoveDisplacements { get; set; }
        public virtual DbSet<ConquestMoveEffectProse> ConquestMoveEffectProse { get; set; }
        public virtual DbSet<ConquestMoveEffects> ConquestMoveEffects { get; set; }
        public virtual DbSet<ConquestMoveRangeProse> ConquestMoveRangeProse { get; set; }
        public virtual DbSet<ConquestMoveRanges> ConquestMoveRanges { get; set; }
        public virtual DbSet<ConquestPokemonAbilities> ConquestPokemonAbilities { get; set; }
        public virtual DbSet<ConquestPokemonEvolution> ConquestPokemonEvolution { get; set; }
        public virtual DbSet<ConquestPokemonMoves> ConquestPokemonMoves { get; set; }
        public virtual DbSet<ConquestPokemonStats> ConquestPokemonStats { get; set; }
        public virtual DbSet<ConquestStatNames> ConquestStatNames { get; set; }
        public virtual DbSet<ConquestStats> ConquestStats { get; set; }
        public virtual DbSet<ConquestTransformationPokemon> ConquestTransformationPokemon { get; set; }
        public virtual DbSet<ConquestTransformationWarriors> ConquestTransformationWarriors { get; set; }
        public virtual DbSet<ConquestWarriorArchetypes> ConquestWarriorArchetypes { get; set; }
        public virtual DbSet<ConquestWarriorNames> ConquestWarriorNames { get; set; }
        public virtual DbSet<ConquestWarriorRankStatMap> ConquestWarriorRankStatMap { get; set; }
        public virtual DbSet<ConquestWarriorRanks> ConquestWarriorRanks { get; set; }
        public virtual DbSet<ConquestWarriorSkillNames> ConquestWarriorSkillNames { get; set; }
        public virtual DbSet<ConquestWarriorSkills> ConquestWarriorSkills { get; set; }
        public virtual DbSet<ConquestWarriorSpecialties> ConquestWarriorSpecialties { get; set; }
        public virtual DbSet<ConquestWarriorStatNames> ConquestWarriorStatNames { get; set; }
        public virtual DbSet<ConquestWarriorStats> ConquestWarriorStats { get; set; }
        public virtual DbSet<ConquestWarriorTransformation> ConquestWarriorTransformation { get; set; }
        public virtual DbSet<ConquestWarriors> ConquestWarriors { get; set; }
        public virtual DbSet<ContestCombos> ContestCombos { get; set; }
        public virtual DbSet<ContestEffectProse> ContestEffectProse { get; set; }
        public virtual DbSet<ContestEffects> ContestEffects { get; set; }
        public virtual DbSet<ContestTypeNames> ContestTypeNames { get; set; }
        public virtual DbSet<ContestTypes> ContestTypes { get; set; }
        public virtual DbSet<EggGroupProse> EggGroupProse { get; set; }
        public virtual DbSet<EggGroups> EggGroups { get; set; }
        public virtual DbSet<EncounterConditionProse> EncounterConditionProse { get; set; }
        public virtual DbSet<EncounterConditionValueMap> EncounterConditionValueMap { get; set; }
        public virtual DbSet<EncounterConditionValueProse> EncounterConditionValueProse { get; set; }
        public virtual DbSet<EncounterConditionValues> EncounterConditionValues { get; set; }
        public virtual DbSet<EncounterConditions> EncounterConditions { get; set; }
        public virtual DbSet<EncounterMethodProse> EncounterMethodProse { get; set; }
        public virtual DbSet<EncounterMethods> EncounterMethods { get; set; }
        public virtual DbSet<EncounterSlots> EncounterSlots { get; set; }
        public virtual DbSet<Encounters> Encounters { get; set; }
        public virtual DbSet<EvolutionChains> EvolutionChains { get; set; }
        public virtual DbSet<EvolutionTriggerProse> EvolutionTriggerProse { get; set; }
        public virtual DbSet<EvolutionTriggers> EvolutionTriggers { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<GenerationNames> GenerationNames { get; set; }
        public virtual DbSet<Generations> Generations { get; set; }
        public virtual DbSet<GrowthRateProse> GrowthRateProse { get; set; }
        public virtual DbSet<GrowthRates> GrowthRates { get; set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; set; }
        public virtual DbSet<ItemCategoryProse> ItemCategoryProse { get; set; }
        public virtual DbSet<ItemFlagMap> ItemFlagMap { get; set; }
        public virtual DbSet<ItemFlagProse> ItemFlagProse { get; set; }
        public virtual DbSet<ItemFlags> ItemFlags { get; set; }
        public virtual DbSet<ItemFlavorSummaries> ItemFlavorSummaries { get; set; }
        public virtual DbSet<ItemFlavorText> ItemFlavorText { get; set; }
        public virtual DbSet<ItemFlingEffectProse> ItemFlingEffectProse { get; set; }
        public virtual DbSet<ItemFlingEffects> ItemFlingEffects { get; set; }
        public virtual DbSet<ItemGameIndices> ItemGameIndices { get; set; }
        public virtual DbSet<ItemNames> ItemNames { get; set; }
        public virtual DbSet<ItemPocketNames> ItemPocketNames { get; set; }
        public virtual DbSet<ItemPockets> ItemPockets { get; set; }
        public virtual DbSet<ItemProse> ItemProse { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<LanguageNames> LanguageNames { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LocationAreaEncounterRates> LocationAreaEncounterRates { get; set; }
        public virtual DbSet<LocationAreaProse> LocationAreaProse { get; set; }
        public virtual DbSet<LocationAreas> LocationAreas { get; set; }
        public virtual DbSet<LocationGameIndices> LocationGameIndices { get; set; }
        public virtual DbSet<LocationNames> LocationNames { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<MoveBattleStyleProse> MoveBattleStyleProse { get; set; }
        public virtual DbSet<MoveBattleStyles> MoveBattleStyles { get; set; }
        public virtual DbSet<MoveChangelog> MoveChangelog { get; set; }
        public virtual DbSet<MoveDamageClassProse> MoveDamageClassProse { get; set; }
        public virtual DbSet<MoveDamageClasses> MoveDamageClasses { get; set; }
        public virtual DbSet<MoveEffectChangelog> MoveEffectChangelog { get; set; }
        public virtual DbSet<MoveEffectChangelogProse> MoveEffectChangelogProse { get; set; }
        public virtual DbSet<MoveEffectProse> MoveEffectProse { get; set; }
        public virtual DbSet<MoveEffects> MoveEffects { get; set; }
        public virtual DbSet<MoveFlagMap> MoveFlagMap { get; set; }
        public virtual DbSet<MoveFlagProse> MoveFlagProse { get; set; }
        public virtual DbSet<MoveFlags> MoveFlags { get; set; }
        public virtual DbSet<MoveFlavorSummaries> MoveFlavorSummaries { get; set; }
        public virtual DbSet<MoveFlavorText> MoveFlavorText { get; set; }
        public virtual DbSet<MoveMeta> MoveMeta { get; set; }
        public virtual DbSet<MoveMetaAilmentNames> MoveMetaAilmentNames { get; set; }
        public virtual DbSet<MoveMetaAilments> MoveMetaAilments { get; set; }
        public virtual DbSet<MoveMetaCategories> MoveMetaCategories { get; set; }
        public virtual DbSet<MoveMetaCategoryProse> MoveMetaCategoryProse { get; set; }
        public virtual DbSet<MoveMetaStatChanges> MoveMetaStatChanges { get; set; }
        public virtual DbSet<MoveNames> MoveNames { get; set; }
        public virtual DbSet<MoveTargetProse> MoveTargetProse { get; set; }
        public virtual DbSet<MoveTargets> MoveTargets { get; set; }
        public virtual DbSet<Moves> Moves { get; set; }
        public virtual DbSet<NatureBattleStylePreferences> NatureBattleStylePreferences { get; set; }
        public virtual DbSet<NatureNames> NatureNames { get; set; }
        public virtual DbSet<NaturePokeathlonStats> NaturePokeathlonStats { get; set; }
        public virtual DbSet<Natures> Natures { get; set; }
        public virtual DbSet<PalPark> PalPark { get; set; }
        public virtual DbSet<PalParkAreaNames> PalParkAreaNames { get; set; }
        public virtual DbSet<PalParkAreas> PalParkAreas { get; set; }
        public virtual DbSet<PokeathlonStatNames> PokeathlonStatNames { get; set; }
        public virtual DbSet<PokeathlonStats> PokeathlonStats { get; set; }
        public virtual DbSet<PokedexProse> PokedexProse { get; set; }
        public virtual DbSet<PokedexVersionGroups> PokedexVersionGroups { get; set; }
        public virtual DbSet<Pokedexes> Pokedexes { get; set; }
        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<PokemonAbilities> PokemonAbilities { get; set; }
        public virtual DbSet<PokemonColorNames> PokemonColorNames { get; set; }
        public virtual DbSet<PokemonColors> PokemonColors { get; set; }
        public virtual DbSet<PokemonDexNumbers> PokemonDexNumbers { get; set; }
        public virtual DbSet<PokemonEggGroups> PokemonEggGroups { get; set; }
        public virtual DbSet<PokemonEvolution> PokemonEvolution { get; set; }
        public virtual DbSet<PokemonFormGenerations> PokemonFormGenerations { get; set; }
        public virtual DbSet<PokemonFormNames> PokemonFormNames { get; set; }
        public virtual DbSet<PokemonFormPokeathlonStats> PokemonFormPokeathlonStats { get; set; }
        public virtual DbSet<PokemonForms> PokemonForms { get; set; }
        public virtual DbSet<PokemonGameIndices> PokemonGameIndices { get; set; }
        public virtual DbSet<PokemonHabitatNames> PokemonHabitatNames { get; set; }
        public virtual DbSet<PokemonHabitats> PokemonHabitats { get; set; }
        public virtual DbSet<PokemonItems> PokemonItems { get; set; }
        public virtual DbSet<PokemonMoveMethodProse> PokemonMoveMethodProse { get; set; }
        public virtual DbSet<PokemonMoveMethods> PokemonMoveMethods { get; set; }
        public virtual DbSet<PokemonMoves> PokemonMoves { get; set; }
        public virtual DbSet<PokemonShapeProse> PokemonShapeProse { get; set; }
        public virtual DbSet<PokemonShapes> PokemonShapes { get; set; }
        public virtual DbSet<PokemonSpecies> PokemonSpecies { get; set; }
        public virtual DbSet<PokemonSpeciesFlavorSummaries> PokemonSpeciesFlavorSummaries { get; set; }
        public virtual DbSet<PokemonSpeciesFlavorText> PokemonSpeciesFlavorText { get; set; }
        public virtual DbSet<PokemonSpeciesNames> PokemonSpeciesNames { get; set; }
        public virtual DbSet<PokemonSpeciesProse> PokemonSpeciesProse { get; set; }
        public virtual DbSet<PokemonStats> PokemonStats { get; set; }
        public virtual DbSet<PokemonTypes> PokemonTypes { get; set; }
        public virtual DbSet<RegionNames> RegionNames { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<StatNames> StatNames { get; set; }
        public virtual DbSet<Stats> Stats { get; set; }
        public virtual DbSet<SuperContestCombos> SuperContestCombos { get; set; }
        public virtual DbSet<SuperContestEffectProse> SuperContestEffectProse { get; set; }
        public virtual DbSet<SuperContestEffects> SuperContestEffects { get; set; }
        public virtual DbSet<TypeEfficacy> TypeEfficacy { get; set; }
        public virtual DbSet<TypeGameIndices> TypeGameIndices { get; set; }
        public virtual DbSet<TypeNames> TypeNames { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<VersionGroupPokemonMoveMethods> VersionGroupPokemonMoveMethods { get; set; }
        public virtual DbSet<VersionGroupRegions> VersionGroupRegions { get; set; }
        public virtual DbSet<VersionGroups> VersionGroups { get; set; }
        public virtual DbSet<VersionNames> VersionNames { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }
        #endregion DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["PokemonDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abilities>(entity =>
            {
                entity.ToTable("abilities");

                entity.HasIndex(e => e.IsMainSeries)
                    .HasName("ix_abilities_is_main_series");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsMainSeries)
                    .IsRequired()
                    .HasColumnName("is_main_series")
                    .HasColumnType("BOOLEAN");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Abilities)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityChangelog>(entity =>
            {
                entity.ToTable("ability_changelog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityChangelog)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.AbilityChangelog)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityChangelogProse>(entity =>
            {
                entity.HasKey(e => new { e.AbilityChangelogId, e.LocalLanguageId });

                entity.ToTable("ability_changelog_prose");

                entity.Property(e => e.AbilityChangelogId).HasColumnName("ability_changelog_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.AbilityChangelog)
                    .WithMany(p => p.AbilityChangelogProse)
                    .HasForeignKey(d => d.AbilityChangelogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityChangelogProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("ability_flavor_text");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityFlavorText)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AbilityFlavorText)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.AbilityFlavorText)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityNames>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.LocalLanguageId });

                entity.ToTable("ability_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_ability_names_name");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityNames)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AbilityProse>(entity =>
            {
                entity.HasKey(e => new { e.AbilityId, e.LocalLanguageId });

                entity.ToTable("ability_prose");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.AbilityProse)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.AbilityProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Berries>(entity =>
            {
                entity.ToTable("berries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirmnessId).HasColumnName("firmness_id");

                entity.Property(e => e.GrowthTime).HasColumnName("growth_time");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MaxHarvest).HasColumnName("max_harvest");

                entity.Property(e => e.NaturalGiftPower).HasColumnName("natural_gift_power");

                entity.Property(e => e.NaturalGiftTypeId).HasColumnName("natural_gift_type_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Smoothness).HasColumnName("smoothness");

                entity.Property(e => e.SoilDryness).HasColumnName("soil_dryness");

                entity.HasOne(d => d.Firmness)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.FirmnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.NaturalGiftType)
                    .WithMany(p => p.Berries)
                    .HasForeignKey(d => d.NaturalGiftTypeId);
            });

            modelBuilder.Entity<BerryFirmness>(entity =>
            {
                entity.ToTable("berry_firmness");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<BerryFirmnessNames>(entity =>
            {
                entity.HasKey(e => new { e.BerryFirmnessId, e.LocalLanguageId });

                entity.ToTable("berry_firmness_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_berry_firmness_names_name");

                entity.Property(e => e.BerryFirmnessId).HasColumnName("berry_firmness_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.BerryFirmness)
                    .WithMany(p => p.BerryFirmnessNames)
                    .HasForeignKey(d => d.BerryFirmnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.BerryFirmnessNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BerryFlavors>(entity =>
            {
                entity.HasKey(e => new { e.BerryId, e.ContestTypeId });

                entity.ToTable("berry_flavors");

                entity.Property(e => e.BerryId).HasColumnName("berry_id");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.Flavor).HasColumnName("flavor");

                entity.HasOne(d => d.Berry)
                    .WithMany(p => p.BerryFlavors)
                    .HasForeignKey(d => d.BerryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.BerryFlavors)
                    .HasForeignKey(d => d.ContestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CharacteristicText>(entity =>
            {
                entity.HasKey(e => new { e.CharacteristicId, e.LocalLanguageId });

                entity.ToTable("characteristic_text");

                entity.HasIndex(e => e.Message)
                    .HasName("ix_characteristic_text_message");

                entity.Property(e => e.CharacteristicId).HasColumnName("characteristic_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Characteristic)
                    .WithMany(p => p.CharacteristicText)
                    .HasForeignKey(d => d.CharacteristicId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.CharacteristicText)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Characteristics>(entity =>
            {
                entity.ToTable("characteristics");

                entity.HasIndex(e => e.GeneMod5)
                    .HasName("ix_characteristics_gene_mod_5");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GeneMod5).HasColumnName("gene_mod_5");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.Characteristics)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestEpisodeNames>(entity =>
            {
                entity.HasKey(e => new { e.EpisodeId, e.LocalLanguageId });

                entity.ToTable("conquest_episode_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_episode_names_name");

                entity.Property(e => e.EpisodeId).HasColumnName("episode_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Episode)
                    .WithMany(p => p.ConquestEpisodeNames)
                    .HasForeignKey(d => d.EpisodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestEpisodeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestEpisodeWarriors>(entity =>
            {
                entity.HasKey(e => new { e.EpisodeId, e.WarriorId });

                entity.ToTable("conquest_episode_warriors");

                entity.Property(e => e.EpisodeId).HasColumnName("episode_id");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.HasOne(d => d.Episode)
                    .WithMany(p => p.ConquestEpisodeWarriors)
                    .HasForeignKey(d => d.EpisodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestEpisodeWarriors)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestEpisodes>(entity =>
            {
                entity.ToTable("conquest_episodes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ConquestKingdomNames>(entity =>
            {
                entity.HasKey(e => new { e.KingdomId, e.LocalLanguageId });

                entity.ToTable("conquest_kingdom_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_kingdom_names_name");

                entity.Property(e => e.KingdomId).HasColumnName("kingdom_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Kingdom)
                    .WithMany(p => p.ConquestKingdomNames)
                    .HasForeignKey(d => d.KingdomId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestKingdomNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestKingdoms>(entity =>
            {
                entity.ToTable("conquest_kingdoms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ConquestKingdoms)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMaxLinks>(entity =>
            {
                entity.HasKey(e => new { e.WarriorRankId, e.PokemonSpeciesId });

                entity.ToTable("conquest_max_links");

                entity.Property(e => e.WarriorRankId).HasColumnName("warrior_rank_id");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.MaxLink).HasColumnName("max_link");

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestMaxLinks)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorRank)
                    .WithMany(p => p.ConquestMaxLinks)
                    .HasForeignKey(d => d.WarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveData>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("conquest_move_data");

                entity.Property(e => e.MoveId)
                    .HasColumnName("move_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.DisplacementId).HasColumnName("displacement_id");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.RangeId).HasColumnName("range_id");

                entity.HasOne(d => d.Displacement)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.DisplacementId);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithOne(p => p.ConquestMoveData)
                    .HasForeignKey<ConquestMoveData>(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Range)
                    .WithMany(p => p.ConquestMoveData)
                    .HasForeignKey(d => d.RangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveDisplacementProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveDisplacementId, e.LocalLanguageId });

                entity.ToTable("conquest_move_displacement_prose");

                entity.Property(e => e.MoveDisplacementId).HasColumnName("move_displacement_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveDisplacementProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveDisplacement)
                    .WithMany(p => p.ConquestMoveDisplacementProse)
                    .HasForeignKey(d => d.MoveDisplacementId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveDisplacements>(entity =>
            {
                entity.ToTable("conquest_move_displacements");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AffectsTarget)
                    .IsRequired()
                    .HasColumnName("affects_target")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ConquestMoveEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ConquestMoveEffectId, e.LocalLanguageId });

                entity.ToTable("conquest_move_effect_prose");

                entity.Property(e => e.ConquestMoveEffectId).HasColumnName("conquest_move_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.ConquestMoveEffect)
                    .WithMany(p => p.ConquestMoveEffectProse)
                    .HasForeignKey(d => d.ConquestMoveEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveEffectProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveEffects>(entity =>
            {
                entity.ToTable("conquest_move_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ConquestMoveRangeProse>(entity =>
            {
                entity.HasKey(e => new { e.ConquestMoveRangeId, e.LocalLanguageId });

                entity.ToTable("conquest_move_range_prose");

                entity.Property(e => e.ConquestMoveRangeId).HasColumnName("conquest_move_range_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ConquestMoveRange)
                    .WithMany(p => p.ConquestMoveRangeProse)
                    .HasForeignKey(d => d.ConquestMoveRangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestMoveRangeProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestMoveRanges>(entity =>
            {
                entity.ToTable("conquest_move_ranges");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Targets).HasColumnName("targets");
            });

            modelBuilder.Entity<ConquestPokemonAbilities>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.Slot });

                entity.ToTable("conquest_pokemon_abilities");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.ConquestPokemonAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestPokemonAbilities)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestPokemonEvolution>(entity =>
            {
                entity.HasKey(e => e.EvolvedSpeciesId);

                entity.ToTable("conquest_pokemon_evolution");

                entity.Property(e => e.EvolvedSpeciesId)
                    .HasColumnName("evolved_species_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.KingdomId).HasColumnName("kingdom_id");

                entity.Property(e => e.MinimumLink).HasColumnName("minimum_link");

                entity.Property(e => e.MinimumStat).HasColumnName("minimum_stat");

                entity.Property(e => e.RecruitingKoRequired)
                    .IsRequired()
                    .HasColumnName("recruiting_ko_required")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.RequiredStatId).HasColumnName("required_stat_id");

                entity.Property(e => e.WarriorGenderId).HasColumnName("warrior_gender_id");

                entity.HasOne(d => d.EvolvedSpecies)
                    .WithOne(p => p.ConquestPokemonEvolution)
                    .HasForeignKey<ConquestPokemonEvolution>(d => d.EvolvedSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ConquestPokemonEvolution)
                    .HasForeignKey(d => d.ItemId);

                entity.HasOne(d => d.Kingdom)
                    .WithMany(p => p.ConquestPokemonEvolution)
                    .HasForeignKey(d => d.KingdomId);

                entity.HasOne(d => d.RequiredStat)
                    .WithMany(p => p.ConquestPokemonEvolution)
                    .HasForeignKey(d => d.RequiredStatId);

                entity.HasOne(d => d.WarriorGender)
                    .WithMany(p => p.ConquestPokemonEvolution)
                    .HasForeignKey(d => d.WarriorGenderId);
            });

            modelBuilder.Entity<ConquestPokemonMoves>(entity =>
            {
                entity.HasKey(e => e.PokemonSpeciesId);

                entity.ToTable("conquest_pokemon_moves");

                entity.Property(e => e.PokemonSpeciesId)
                    .HasColumnName("pokemon_species_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.ConquestPokemonMoves)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithOne(p => p.ConquestPokemonMoves)
                    .HasForeignKey<ConquestPokemonMoves>(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestPokemonStats>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.ConquestStatId });

                entity.ToTable("conquest_pokemon_stats");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.ConquestStatId).HasColumnName("conquest_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.HasOne(d => d.ConquestStat)
                    .WithMany(p => p.ConquestPokemonStats)
                    .HasForeignKey(d => d.ConquestStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestPokemonStats)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestStatNames>(entity =>
            {
                entity.HasKey(e => new { e.ConquestStatId, e.LocalLanguageId });

                entity.ToTable("conquest_stat_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_stat_names_name");

                entity.Property(e => e.ConquestStatId).HasColumnName("conquest_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ConquestStat)
                    .WithMany(p => p.ConquestStatNames)
                    .HasForeignKey(d => d.ConquestStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestStats>(entity =>
            {
                entity.ToTable("conquest_stats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsBase)
                    .IsRequired()
                    .HasColumnName("is_base")
                    .HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<ConquestTransformationPokemon>(entity =>
            {
                entity.HasKey(e => new { e.TransformationId, e.PokemonSpeciesId });

                entity.ToTable("conquest_transformation_pokemon");

                entity.Property(e => e.TransformationId).HasColumnName("transformation_id");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.ConquestTransformationPokemon)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Transformation)
                    .WithMany(p => p.ConquestTransformationPokemon)
                    .HasForeignKey(d => d.TransformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestTransformationWarriors>(entity =>
            {
                entity.HasKey(e => new { e.TransformationId, e.PresentWarriorId });

                entity.ToTable("conquest_transformation_warriors");

                entity.Property(e => e.TransformationId).HasColumnName("transformation_id");

                entity.Property(e => e.PresentWarriorId).HasColumnName("present_warrior_id");

                entity.HasOne(d => d.PresentWarrior)
                    .WithMany(p => p.ConquestTransformationWarriors)
                    .HasForeignKey(d => d.PresentWarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Transformation)
                    .WithMany(p => p.ConquestTransformationWarriors)
                    .HasForeignKey(d => d.TransformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorArchetypes>(entity =>
            {
                entity.ToTable("conquest_warrior_archetypes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ConquestWarriorNames>(entity =>
            {
                entity.HasKey(e => new { e.WarriorId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_warrior_names_name");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorNames)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorRankStatMap>(entity =>
            {
                entity.HasKey(e => new { e.WarriorRankId, e.WarriorStatId });

                entity.ToTable("conquest_warrior_rank_stat_map");

                entity.Property(e => e.WarriorRankId).HasColumnName("warrior_rank_id");

                entity.Property(e => e.WarriorStatId).HasColumnName("warrior_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.HasOne(d => d.WarriorRank)
                    .WithMany(p => p.ConquestWarriorRankStatMap)
                    .HasForeignKey(d => d.WarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorStat)
                    .WithMany(p => p.ConquestWarriorRankStatMap)
                    .HasForeignKey(d => d.WarriorStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorRanks>(entity =>
            {
                entity.ToTable("conquest_warrior_ranks");

                entity.HasIndex(e => new { e.WarriorId, e.Rank })
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ConquestWarriorRanks)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorRanks)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorSkillNames>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_skill_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_warrior_skill_names_name");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorSkillNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ConquestWarriorSkillNames)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorSkills>(entity =>
            {
                entity.ToTable("conquest_warrior_skills");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ConquestWarriorSpecialties>(entity =>
            {
                entity.HasKey(e => new { e.WarriorId, e.TypeId, e.Slot });

                entity.ToTable("conquest_warrior_specialties");

                entity.Property(e => e.WarriorId).HasColumnName("warrior_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ConquestWarriorSpecialties)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Warrior)
                    .WithMany(p => p.ConquestWarriorSpecialties)
                    .HasForeignKey(d => d.WarriorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorStatNames>(entity =>
            {
                entity.HasKey(e => new { e.WarriorStatId, e.LocalLanguageId });

                entity.ToTable("conquest_warrior_stat_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_conquest_warrior_stat_names_name");

                entity.Property(e => e.WarriorStatId).HasColumnName("warrior_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ConquestWarriorStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WarriorStat)
                    .WithMany(p => p.ConquestWarriorStatNames)
                    .HasForeignKey(d => d.WarriorStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriorStats>(entity =>
            {
                entity.ToTable("conquest_warrior_stats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ConquestWarriorTransformation>(entity =>
            {
                entity.HasKey(e => e.TransformedWarriorRankId);

                entity.ToTable("conquest_warrior_transformation");

                entity.Property(e => e.TransformedWarriorRankId)
                    .HasColumnName("transformed_warrior_rank_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CollectionTypeId).HasColumnName("collection_type_id");

                entity.Property(e => e.CompletedEpisodeId).HasColumnName("completed_episode_id");

                entity.Property(e => e.CurrentEpisodeId).HasColumnName("current_episode_id");

                entity.Property(e => e.DistantWarriorId).HasColumnName("distant_warrior_id");

                entity.Property(e => e.FemaleWarlordCount).HasColumnName("female_warlord_count");

                entity.Property(e => e.IsAutomatic)
                    .IsRequired()
                    .HasColumnName("is_automatic")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.PokemonCount).HasColumnName("pokemon_count");

                entity.Property(e => e.RequiredLink).HasColumnName("required_link");

                entity.Property(e => e.WarriorCount).HasColumnName("warrior_count");

                entity.HasOne(d => d.CollectionType)
                    .WithMany(p => p.ConquestWarriorTransformation)
                    .HasForeignKey(d => d.CollectionTypeId);

                entity.HasOne(d => d.CompletedEpisode)
                    .WithMany(p => p.ConquestWarriorTransformationCompletedEpisode)
                    .HasForeignKey(d => d.CompletedEpisodeId);

                entity.HasOne(d => d.CurrentEpisode)
                    .WithMany(p => p.ConquestWarriorTransformationCurrentEpisode)
                    .HasForeignKey(d => d.CurrentEpisodeId);

                entity.HasOne(d => d.DistantWarrior)
                    .WithMany(p => p.ConquestWarriorTransformation)
                    .HasForeignKey(d => d.DistantWarriorId);

                entity.HasOne(d => d.TransformedWarriorRank)
                    .WithOne(p => p.ConquestWarriorTransformation)
                    .HasForeignKey<ConquestWarriorTransformation>(d => d.TransformedWarriorRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConquestWarriors>(entity =>
            {
                entity.ToTable("conquest_warriors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchetypeId).HasColumnName("archetype_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Archetype)
                    .WithMany(p => p.ConquestWarriors)
                    .HasForeignKey(d => d.ArchetypeId);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.ConquestWarriors)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestCombos>(entity =>
            {
                entity.HasKey(e => new { e.FirstMoveId, e.SecondMoveId });

                entity.ToTable("contest_combos");

                entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");

                entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

                entity.HasOne(d => d.FirstMove)
                    .WithMany(p => p.ContestCombosFirstMove)
                    .HasForeignKey(d => d.FirstMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SecondMove)
                    .WithMany(p => p.ContestCombosSecondMove)
                    .HasForeignKey(d => d.SecondMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ContestEffectId, e.LocalLanguageId });

                entity.ToTable("contest_effect_prose");

                entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.FlavorText).HasColumnName("flavor_text");

                entity.HasOne(d => d.ContestEffect)
                    .WithMany(p => p.ContestEffectProse)
                    .HasForeignKey(d => d.ContestEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ContestEffectProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestEffects>(entity =>
            {
                entity.ToTable("contest_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Appeal)
                    .HasColumnName("appeal")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.Jam)
                    .HasColumnName("jam")
                    .HasColumnType("SMALLINT");
            });

            modelBuilder.Entity<ContestTypeNames>(entity =>
            {
                entity.HasKey(e => new { e.ContestTypeId, e.LocalLanguageId });

                entity.ToTable("contest_type_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_contest_type_names_name");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.Flavor).HasColumnName("flavor");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.ContestTypeNames)
                    .HasForeignKey(d => d.ContestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ContestTypeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContestTypes>(entity =>
            {
                entity.ToTable("contest_types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<EggGroupProse>(entity =>
            {
                entity.HasKey(e => new { e.EggGroupId, e.LocalLanguageId });

                entity.ToTable("egg_group_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_egg_group_prose_name");

                entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.EggGroup)
                    .WithMany(p => p.EggGroupProse)
                    .HasForeignKey(d => d.EggGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EggGroupProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EggGroups>(entity =>
            {
                entity.ToTable("egg_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<EncounterConditionProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterConditionId, e.LocalLanguageId });

                entity.ToTable("encounter_condition_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_encounter_condition_prose_name");

                entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.EncounterCondition)
                    .WithMany(p => p.EncounterConditionProse)
                    .HasForeignKey(d => d.EncounterConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterConditionProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValueMap>(entity =>
            {
                entity.HasKey(e => new { e.EncounterId, e.EncounterConditionValueId });

                entity.ToTable("encounter_condition_value_map");

                entity.Property(e => e.EncounterId).HasColumnName("encounter_id");

                entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");

                entity.HasOne(d => d.EncounterConditionValue)
                    .WithMany(p => p.EncounterConditionValueMap)
                    .HasForeignKey(d => d.EncounterConditionValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Encounter)
                    .WithMany(p => p.EncounterConditionValueMap)
                    .HasForeignKey(d => d.EncounterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValueProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterConditionValueId, e.LocalLanguageId });

                entity.ToTable("encounter_condition_value_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_encounter_condition_value_prose_name");

                entity.Property(e => e.EncounterConditionValueId).HasColumnName("encounter_condition_value_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.EncounterConditionValue)
                    .WithMany(p => p.EncounterConditionValueProse)
                    .HasForeignKey(d => d.EncounterConditionValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterConditionValueProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditionValues>(entity =>
            {
                entity.ToTable("encounter_condition_values");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncounterConditionId).HasColumnName("encounter_condition_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("is_default")
                    .HasColumnType("BOOLEAN");

                entity.HasOne(d => d.EncounterCondition)
                    .WithMany(p => p.EncounterConditionValues)
                    .HasForeignKey(d => d.EncounterConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterConditions>(entity =>
            {
                entity.ToTable("encounter_conditions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<EncounterMethodProse>(entity =>
            {
                entity.HasKey(e => new { e.EncounterMethodId, e.LocalLanguageId });

                entity.ToTable("encounter_method_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_encounter_method_prose_name");

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.EncounterMethodProse)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EncounterMethodProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EncounterMethods>(entity =>
            {
                entity.ToTable("encounter_methods");

                entity.HasIndex(e => e.Identifier)
                    .IsUnique();

                entity.HasIndex(e => e.Order)
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<EncounterSlots>(entity =>
            {
                entity.ToTable("encounter_slots");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.EncounterSlots)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.EncounterSlots)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Encounters>(entity =>
            {
                entity.ToTable("encounters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncounterSlotId).HasColumnName("encounter_slot_id");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.HasOne(d => d.EncounterSlot)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.EncounterSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.Encounters)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EvolutionChains>(entity =>
            {
                entity.ToTable("evolution_chains");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BabyTriggerItemId).HasColumnName("baby_trigger_item_id");

                entity.HasOne(d => d.BabyTriggerItem)
                    .WithMany(p => p.EvolutionChains)
                    .HasForeignKey(d => d.BabyTriggerItemId);
            });

            modelBuilder.Entity<EvolutionTriggerProse>(entity =>
            {
                entity.HasKey(e => new { e.EvolutionTriggerId, e.LocalLanguageId });

                entity.ToTable("evolution_trigger_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_evolution_trigger_prose_name");

                entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.EvolutionTrigger)
                    .WithMany(p => p.EvolutionTriggerProse)
                    .HasForeignKey(d => d.EvolutionTriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.EvolutionTriggerProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EvolutionTriggers>(entity =>
            {
                entity.ToTable("evolution_triggers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.HasKey(e => new { e.GrowthRateId, e.Level });

                entity.ToTable("experience");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Experience1).HasColumnName("experience");

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.ToTable("genders");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<GenerationNames>(entity =>
            {
                entity.HasKey(e => new { e.GenerationId, e.LocalLanguageId });

                entity.ToTable("generation_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_generation_names_name");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.GenerationNames)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.GenerationNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Generations>(entity =>
            {
                entity.ToTable("generations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.MainRegionId).HasColumnName("main_region_id");

                entity.HasOne(d => d.MainRegion)
                    .WithMany(p => p.Generations)
                    .HasForeignKey(d => d.MainRegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<GrowthRateProse>(entity =>
            {
                entity.HasKey(e => new { e.GrowthRateId, e.LocalLanguageId });

                entity.ToTable("growth_rate_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_growth_rate_prose_name");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.GrowthRateProse)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.GrowthRateProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<GrowthRates>(entity =>
            {
                entity.ToTable("growth_rates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasColumnName("formula");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ItemCategories>(entity =>
            {
                entity.ToTable("item_categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.PocketId).HasColumnName("pocket_id");

                entity.HasOne(d => d.Pocket)
                    .WithMany(p => p.ItemCategories)
                    .HasForeignKey(d => d.PocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemCategoryProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemCategoryId, e.LocalLanguageId });

                entity.ToTable("item_category_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_item_category_prose_name");

                entity.Property(e => e.ItemCategoryId).HasColumnName("item_category_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.ItemCategoryProse)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemCategoryProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlagMap>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ItemFlagId });

                entity.ToTable("item_flag_map");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemFlagId).HasColumnName("item_flag_id");

                entity.HasOne(d => d.ItemFlag)
                    .WithMany(p => p.ItemFlagMap)
                    .HasForeignKey(d => d.ItemFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlagMap)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlagProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemFlagId, e.LocalLanguageId });

                entity.ToTable("item_flag_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_item_flag_prose_name");

                entity.Property(e => e.ItemFlagId).HasColumnName("item_flag_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ItemFlag)
                    .WithMany(p => p.ItemFlagProse)
                    .HasForeignKey(d => d.ItemFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlagProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlags>(entity =>
            {
                entity.ToTable("item_flags");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ItemFlavorSummaries>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_flavor_summaries");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlavorSummaries)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("item_flavor_text");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemFlavorText)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ItemFlavorText)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.ItemFlavorText)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlingEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemFlingEffectId, e.LocalLanguageId });

                entity.ToTable("item_fling_effect_prose");

                entity.Property(e => e.ItemFlingEffectId).HasColumnName("item_fling_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.ItemFlingEffect)
                    .WithMany(p => p.ItemFlingEffectProse)
                    .HasForeignKey(d => d.ItemFlingEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemFlingEffectProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemFlingEffects>(entity =>
            {
                entity.ToTable("item_fling_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ItemGameIndices>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.GenerationId });

                entity.ToTable("item_game_indices");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.ItemGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemGameIndices)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemNames>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_item_names_name");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemNames)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemPocketNames>(entity =>
            {
                entity.HasKey(e => new { e.ItemPocketId, e.LocalLanguageId });

                entity.ToTable("item_pocket_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_item_pocket_names_name");

                entity.Property(e => e.ItemPocketId).HasColumnName("item_pocket_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.ItemPocket)
                    .WithMany(p => p.ItemPocketNames)
                    .HasForeignKey(d => d.ItemPocketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemPocketNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ItemPockets>(entity =>
            {
                entity.ToTable("item_pockets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<ItemProse>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.LocalLanguageId });

                entity.ToTable("item_prose");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemProse)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.ItemProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.FlingEffectId).HasColumnName("fling_effect_id");

                entity.Property(e => e.FlingPower).HasColumnName("fling_power");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FlingEffect)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.FlingEffectId);
            });

            modelBuilder.Entity<LanguageNames>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.LocalLanguageId });

                entity.ToTable("language_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_language_names_name");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageNamesLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LanguageNamesLocalLanguage)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.ToTable("languages");

                entity.HasIndex(e => e.Official)
                    .HasName("ix_languages_official");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Iso3166)
                    .IsRequired()
                    .HasColumnName("iso3166")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Iso639)
                    .IsRequired()
                    .HasColumnName("iso639")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Official)
                    .IsRequired()
                    .HasColumnName("official")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<LocationAreaEncounterRates>(entity =>
            {
                entity.HasKey(e => new { e.LocationAreaId, e.EncounterMethodId, e.VersionId });

                entity.ToTable("location_area_encounter_rates");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.EncounterMethodId).HasColumnName("encounter_method_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.EncounterMethod)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.EncounterMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.LocationAreaEncounterRates)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationAreaProse>(entity =>
            {
                entity.HasKey(e => new { e.LocationAreaId, e.LocalLanguageId });

                entity.ToTable("location_area_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_location_area_prose_name");

                entity.Property(e => e.LocationAreaId).HasColumnName("location_area_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LocationAreaProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LocationArea)
                    .WithMany(p => p.LocationAreaProse)
                    .HasForeignKey(d => d.LocationAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationAreas>(entity =>
            {
                entity.ToTable("location_areas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.Identifier)
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationAreas)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationGameIndices>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.GenerationId, e.GameIndex });

                entity.ToTable("location_game_indices");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.LocationGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationGameIndices)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocationNames>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.LocalLanguageId });

                entity.ToTable("location_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_location_names_name");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.LocationNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationNames)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("locations");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<Machines>(entity =>
            {
                entity.HasKey(e => new { e.MachineNumber, e.VersionGroupId });

                entity.ToTable("machines");

                entity.Property(e => e.MachineNumber).HasColumnName("machine_number");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveBattleStyleProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveBattleStyleId, e.LocalLanguageId });

                entity.ToTable("move_battle_style_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_battle_style_prose_name");

                entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveBattleStyleProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveBattleStyle)
                    .WithMany(p => p.MoveBattleStyleProse)
                    .HasForeignKey(d => d.MoveBattleStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveBattleStyles>(entity =>
            {
                entity.ToTable("move_battle_styles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<MoveChangelog>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.ChangedInVersionGroupId });

                entity.ToTable("move_changelog");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.Property(e => e.Accuracy)
                    .HasColumnName("accuracy")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Power)
                    .HasColumnName("power")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.Pp)
                    .HasColumnName("pp")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.MoveChangelog)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.MoveChangelog)
                    .HasForeignKey(d => d.EffectId);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveChangelog)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.MoveChangelog)
                    .HasForeignKey(d => d.TargetId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MoveChangelog)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<MoveDamageClassProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveDamageClassId, e.LocalLanguageId });

                entity.ToTable("move_damage_class_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_damage_class_prose_name");

                entity.Property(e => e.MoveDamageClassId).HasColumnName("move_damage_class_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveDamageClassProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveDamageClass)
                    .WithMany(p => p.MoveDamageClassProse)
                    .HasForeignKey(d => d.MoveDamageClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveDamageClasses>(entity =>
            {
                entity.ToTable("move_damage_classes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<MoveEffectChangelog>(entity =>
            {
                entity.ToTable("move_effect_changelog");

                entity.HasIndex(e => new { e.EffectId, e.ChangedInVersionGroupId })
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangedInVersionGroupId).HasColumnName("changed_in_version_group_id");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.HasOne(d => d.ChangedInVersionGroup)
                    .WithMany(p => p.MoveEffectChangelog)
                    .HasForeignKey(d => d.ChangedInVersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.MoveEffectChangelog)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffectChangelogProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveEffectChangelogId, e.LocalLanguageId });

                entity.ToTable("move_effect_changelog_prose");

                entity.Property(e => e.MoveEffectChangelogId).HasColumnName("move_effect_changelog_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasColumnName("effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveEffectChangelogProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveEffectChangelog)
                    .WithMany(p => p.MoveEffectChangelogProse)
                    .HasForeignKey(d => d.MoveEffectChangelogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveEffectId, e.LocalLanguageId });

                entity.ToTable("move_effect_prose");

                entity.Property(e => e.MoveEffectId).HasColumnName("move_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Effect).HasColumnName("effect");

                entity.Property(e => e.ShortEffect).HasColumnName("short_effect");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveEffectProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveEffect)
                    .WithMany(p => p.MoveEffectProse)
                    .HasForeignKey(d => d.MoveEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveEffects>(entity =>
            {
                entity.ToTable("move_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<MoveFlagMap>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.MoveFlagId });

                entity.ToTable("move_flag_map");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.MoveFlagId).HasColumnName("move_flag_id");

                entity.HasOne(d => d.MoveFlag)
                    .WithMany(p => p.MoveFlagMap)
                    .HasForeignKey(d => d.MoveFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlagMap)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlagProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveFlagId, e.LocalLanguageId });

                entity.ToTable("move_flag_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_flag_prose_name");

                entity.Property(e => e.MoveFlagId).HasColumnName("move_flag_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveFlagProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveFlag)
                    .WithMany(p => p.MoveFlagProse)
                    .HasForeignKey(d => d.MoveFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlags>(entity =>
            {
                entity.ToTable("move_flags");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<MoveFlavorSummaries>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.LocalLanguageId });

                entity.ToTable("move_flavor_summaries");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlavorSummaries)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.VersionGroupId, e.LanguageId });

                entity.ToTable("move_flavor_text");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.MoveFlavorText)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveFlavorText)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.MoveFlavorText)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMeta>(entity =>
            {
                entity.HasKey(e => e.MoveId);

                entity.ToTable("move_meta");

                entity.HasIndex(e => e.AilmentChance)
                    .HasName("ix_move_meta_ailment_chance");

                entity.HasIndex(e => e.CritRate)
                    .HasName("ix_move_meta_crit_rate");

                entity.HasIndex(e => e.Drain)
                    .HasName("ix_move_meta_drain");

                entity.HasIndex(e => e.FlinchChance)
                    .HasName("ix_move_meta_flinch_chance");

                entity.HasIndex(e => e.Healing)
                    .HasName("ix_move_meta_healing");

                entity.HasIndex(e => e.MaxHits)
                    .HasName("ix_move_meta_max_hits");

                entity.HasIndex(e => e.MaxTurns)
                    .HasName("ix_move_meta_max_turns");

                entity.HasIndex(e => e.MinHits)
                    .HasName("ix_move_meta_min_hits");

                entity.HasIndex(e => e.MinTurns)
                    .HasName("ix_move_meta_min_turns");

                entity.HasIndex(e => e.StatChance)
                    .HasName("ix_move_meta_stat_chance");

                entity.Property(e => e.MoveId)
                    .HasColumnName("move_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AilmentChance).HasColumnName("ailment_chance");

                entity.Property(e => e.CritRate).HasColumnName("crit_rate");

                entity.Property(e => e.Drain).HasColumnName("drain");

                entity.Property(e => e.FlinchChance).HasColumnName("flinch_chance");

                entity.Property(e => e.Healing).HasColumnName("healing");

                entity.Property(e => e.MaxHits).HasColumnName("max_hits");

                entity.Property(e => e.MaxTurns).HasColumnName("max_turns");

                entity.Property(e => e.MetaAilmentId).HasColumnName("meta_ailment_id");

                entity.Property(e => e.MetaCategoryId).HasColumnName("meta_category_id");

                entity.Property(e => e.MinHits).HasColumnName("min_hits");

                entity.Property(e => e.MinTurns).HasColumnName("min_turns");

                entity.Property(e => e.StatChance).HasColumnName("stat_chance");

                entity.HasOne(d => d.MetaAilment)
                    .WithMany(p => p.MoveMeta)
                    .HasForeignKey(d => d.MetaAilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MetaCategory)
                    .WithMany(p => p.MoveMeta)
                    .HasForeignKey(d => d.MetaCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithOne(p => p.MoveMeta)
                    .HasForeignKey<MoveMeta>(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaAilmentNames>(entity =>
            {
                entity.HasKey(e => new { e.MoveMetaAilmentId, e.LocalLanguageId });

                entity.ToTable("move_meta_ailment_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_meta_ailment_names_name");

                entity.Property(e => e.MoveMetaAilmentId).HasColumnName("move_meta_ailment_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveMetaAilmentNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveMetaAilment)
                    .WithMany(p => p.MoveMetaAilmentNames)
                    .HasForeignKey(d => d.MoveMetaAilmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaAilments>(entity =>
            {
                entity.ToTable("move_meta_ailments");

                entity.HasIndex(e => e.Identifier)
                    .HasName("ix_move_meta_ailments_identifier")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<MoveMetaCategories>(entity =>
            {
                entity.ToTable("move_meta_categories");

                entity.HasIndex(e => e.Identifier)
                    .HasName("ix_move_meta_categories_identifier")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<MoveMetaCategoryProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveMetaCategoryId, e.LocalLanguageId });

                entity.ToTable("move_meta_category_prose");

                entity.Property(e => e.MoveMetaCategoryId).HasColumnName("move_meta_category_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveMetaCategoryProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveMetaCategory)
                    .WithMany(p => p.MoveMetaCategoryProse)
                    .HasForeignKey(d => d.MoveMetaCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveMetaStatChanges>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.StatId });

                entity.ToTable("move_meta_stat_changes");

                entity.HasIndex(e => e.Change)
                    .HasName("ix_move_meta_stat_changes_change");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.Change).HasColumnName("change");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveMetaStatChanges)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.MoveMetaStatChanges)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveNames>(entity =>
            {
                entity.HasKey(e => new { e.MoveId, e.LocalLanguageId });

                entity.ToTable("move_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_names_name");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.MoveNames)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveTargetProse>(entity =>
            {
                entity.HasKey(e => new { e.MoveTargetId, e.LocalLanguageId });

                entity.ToTable("move_target_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_move_target_prose_name");

                entity.Property(e => e.MoveTargetId).HasColumnName("move_target_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.MoveTargetProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MoveTarget)
                    .WithMany(p => p.MoveTargetProse)
                    .HasForeignKey(d => d.MoveTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MoveTargets>(entity =>
            {
                entity.ToTable("move_targets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<Moves>(entity =>
            {
                entity.ToTable("moves");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy)
                    .HasColumnName("accuracy")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.ContestEffectId).HasColumnName("contest_effect_id");

                entity.Property(e => e.ContestTypeId).HasColumnName("contest_type_id");

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.EffectChance).HasColumnName("effect_chance");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Power)
                    .HasColumnName("power")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.Pp)
                    .HasColumnName("pp")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("SMALLINT");

                entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.ContestEffect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.ContestEffectId);

                entity.HasOne(d => d.ContestType)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.ContestTypeId);

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.DamageClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Effect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.EffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuperContestEffect)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.SuperContestEffectId);

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.TargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NatureBattleStylePreferences>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.MoveBattleStyleId });

                entity.ToTable("nature_battle_style_preferences");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.MoveBattleStyleId).HasColumnName("move_battle_style_id");

                entity.Property(e => e.HighHpPreference).HasColumnName("high_hp_preference");

                entity.Property(e => e.LowHpPreference).HasColumnName("low_hp_preference");

                entity.HasOne(d => d.MoveBattleStyle)
                    .WithMany(p => p.NatureBattleStylePreferences)
                    .HasForeignKey(d => d.MoveBattleStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NatureBattleStylePreferences)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NatureNames>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.LocalLanguageId });

                entity.ToTable("nature_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_nature_names_name");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.NatureNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NatureNames)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NaturePokeathlonStats>(entity =>
            {
                entity.HasKey(e => new { e.NatureId, e.PokeathlonStatId });

                entity.ToTable("nature_pokeathlon_stats");

                entity.Property(e => e.NatureId).HasColumnName("nature_id");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.MaxChange).HasColumnName("max_change");

                entity.HasOne(d => d.Nature)
                    .WithMany(p => p.NaturePokeathlonStats)
                    .HasForeignKey(d => d.NatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.NaturePokeathlonStats)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Natures>(entity =>
            {
                entity.ToTable("natures");

                entity.HasIndex(e => e.GameIndex)
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DecreasedStatId).HasColumnName("decreased_stat_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.HatesFlavorId).HasColumnName("hates_flavor_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IncreasedStatId).HasColumnName("increased_stat_id");

                entity.Property(e => e.LikesFlavorId).HasColumnName("likes_flavor_id");

                entity.HasOne(d => d.DecreasedStat)
                    .WithMany(p => p.NaturesDecreasedStat)
                    .HasForeignKey(d => d.DecreasedStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.HatesFlavor)
                    .WithMany(p => p.NaturesHatesFlavor)
                    .HasForeignKey(d => d.HatesFlavorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IncreasedStat)
                    .WithMany(p => p.NaturesIncreasedStat)
                    .HasForeignKey(d => d.IncreasedStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LikesFlavor)
                    .WithMany(p => p.NaturesLikesFlavor)
                    .HasForeignKey(d => d.LikesFlavorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PalPark>(entity =>
            {
                entity.HasKey(e => e.SpeciesId);

                entity.ToTable("pal_park");

                entity.Property(e => e.SpeciesId)
                    .HasColumnName("species_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BaseScore).HasColumnName("base_score");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.PalPark)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithOne(p => p.PalPark)
                    .HasForeignKey<PalPark>(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PalParkAreaNames>(entity =>
            {
                entity.HasKey(e => new { e.PalParkAreaId, e.LocalLanguageId });

                entity.ToTable("pal_park_area_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pal_park_area_names_name");

                entity.Property(e => e.PalParkAreaId).HasColumnName("pal_park_area_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PalParkAreaNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PalParkArea)
                    .WithMany(p => p.PalParkAreaNames)
                    .HasForeignKey(d => d.PalParkAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PalParkAreas>(entity =>
            {
                entity.ToTable("pal_park_areas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokeathlonStatNames>(entity =>
            {
                entity.HasKey(e => new { e.PokeathlonStatId, e.LocalLanguageId });

                entity.ToTable("pokeathlon_stat_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokeathlon_stat_names_name");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokeathlonStatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.PokeathlonStatNames)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokeathlonStats>(entity =>
            {
                entity.ToTable("pokeathlon_stats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokedexProse>(entity =>
            {
                entity.HasKey(e => new { e.PokedexId, e.LocalLanguageId });

                entity.ToTable("pokedex_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokedex_prose_name");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokedexProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokedexProse)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokedexVersionGroups>(entity =>
            {
                entity.HasKey(e => new { e.PokedexId, e.VersionGroupId });

                entity.ToTable("pokedex_version_groups");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokedexVersionGroups)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.PokedexVersionGroups)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Pokedexes>(entity =>
            {
                entity.ToTable("pokedexes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsMainSeries)
                    .IsRequired()
                    .HasColumnName("is_main_series")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Pokedexes)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.ToTable("pokemon");

                entity.HasIndex(e => e.IsDefault)
                    .HasName("ix_pokemon_is_default");

                entity.HasIndex(e => e.Order)
                    .HasName("ix_pokemon_order");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseExperience).HasColumnName("base_experience");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("is_default")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.Pokemon)
                    .HasForeignKey(d => d.SpeciesId);
            });

            modelBuilder.Entity<PokemonAbilities>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.Slot });

                entity.ToTable("pokemon_abilities");

                entity.HasIndex(e => e.IsHidden)
                    .HasName("ix_pokemon_abilities_is_hidden");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasColumnName("is_hidden")
                    .HasColumnType("BOOLEAN");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.PokemonAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonAbilities)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonColorNames>(entity =>
            {
                entity.HasKey(e => new { e.PokemonColorId, e.LocalLanguageId });

                entity.ToTable("pokemon_color_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokemon_color_names_name");

                entity.Property(e => e.PokemonColorId).HasColumnName("pokemon_color_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonColorNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonColor)
                    .WithMany(p => p.PokemonColorNames)
                    .HasForeignKey(d => d.PokemonColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonColors>(entity =>
            {
                entity.ToTable("pokemon_colors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokemonDexNumbers>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.PokedexId });

                entity.ToTable("pokemon_dex_numbers");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.PokedexId).HasColumnName("pokedex_id");

                entity.Property(e => e.PokedexNumber).HasColumnName("pokedex_number");

                entity.HasOne(d => d.Pokedex)
                    .WithMany(p => p.PokemonDexNumbers)
                    .HasForeignKey(d => d.PokedexId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonDexNumbers)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonEggGroups>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.EggGroupId });

                entity.ToTable("pokemon_egg_groups");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.EggGroupId).HasColumnName("egg_group_id");

                entity.HasOne(d => d.EggGroup)
                    .WithMany(p => p.PokemonEggGroups)
                    .HasForeignKey(d => d.EggGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonEggGroups)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonEvolution>(entity =>
            {
                entity.ToTable("pokemon_evolution");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvolutionTriggerId).HasColumnName("evolution_trigger_id");

                entity.Property(e => e.EvolvedSpeciesId).HasColumnName("evolved_species_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.HeldItemId).HasColumnName("held_item_id");

                entity.Property(e => e.KnownMoveId).HasColumnName("known_move_id");

                entity.Property(e => e.KnownMoveTypeId).HasColumnName("known_move_type_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MinimumAffection).HasColumnName("minimum_affection");

                entity.Property(e => e.MinimumBeauty).HasColumnName("minimum_beauty");

                entity.Property(e => e.MinimumHappiness).HasColumnName("minimum_happiness");

                entity.Property(e => e.MinimumLevel).HasColumnName("minimum_level");

                entity.Property(e => e.NeedsOverworldRain)
                    .IsRequired()
                    .HasColumnName("needs_overworld_rain")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.PartySpeciesId).HasColumnName("party_species_id");

                entity.Property(e => e.PartyTypeId).HasColumnName("party_type_id");

                entity.Property(e => e.RelativePhysicalStats).HasColumnName("relative_physical_stats");

                entity.Property(e => e.TimeOfDay)
                    .HasColumnName("time_of_day")
                    .HasColumnType("VARCHAR(5)");

                entity.Property(e => e.TradeSpeciesId).HasColumnName("trade_species_id");

                entity.Property(e => e.TriggerItemId).HasColumnName("trigger_item_id");

                entity.Property(e => e.TurnUpsideDown)
                    .IsRequired()
                    .HasColumnName("turn_upside_down")
                    .HasColumnType("BOOLEAN");

                entity.HasOne(d => d.EvolutionTrigger)
                    .WithMany(p => p.PokemonEvolution)
                    .HasForeignKey(d => d.EvolutionTriggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EvolvedSpecies)
                    .WithMany(p => p.PokemonEvolutionEvolvedSpecies)
                    .HasForeignKey(d => d.EvolvedSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.PokemonEvolution)
                    .HasForeignKey(d => d.GenderId);

                entity.HasOne(d => d.HeldItem)
                    .WithMany(p => p.PokemonEvolutionHeldItem)
                    .HasForeignKey(d => d.HeldItemId);

                entity.HasOne(d => d.KnownMove)
                    .WithMany(p => p.PokemonEvolution)
                    .HasForeignKey(d => d.KnownMoveId);

                entity.HasOne(d => d.KnownMoveType)
                    .WithMany(p => p.PokemonEvolutionKnownMoveType)
                    .HasForeignKey(d => d.KnownMoveTypeId);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PokemonEvolution)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.PartySpecies)
                    .WithMany(p => p.PokemonEvolutionPartySpecies)
                    .HasForeignKey(d => d.PartySpeciesId);

                entity.HasOne(d => d.PartyType)
                    .WithMany(p => p.PokemonEvolutionPartyType)
                    .HasForeignKey(d => d.PartyTypeId);

                entity.HasOne(d => d.TradeSpecies)
                    .WithMany(p => p.PokemonEvolutionTradeSpecies)
                    .HasForeignKey(d => d.TradeSpeciesId);

                entity.HasOne(d => d.TriggerItem)
                    .WithMany(p => p.PokemonEvolutionTriggerItem)
                    .HasForeignKey(d => d.TriggerItemId);
            });

            modelBuilder.Entity<PokemonFormGenerations>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.GenerationId });

                entity.ToTable("pokemon_form_generations");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.PokemonFormGenerations)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormGenerations)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonFormNames>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.LocalLanguageId });

                entity.ToTable("pokemon_form_names");

                entity.HasIndex(e => e.FormName)
                    .HasName("ix_pokemon_form_names_form_name");

                entity.HasIndex(e => e.PokemonName)
                    .HasName("ix_pokemon_form_names_pokemon_name");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FormName)
                    .HasColumnName("form_name")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.PokemonName)
                    .HasColumnName("pokemon_name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonFormNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormNames)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonFormPokeathlonStats>(entity =>
            {
                entity.HasKey(e => new { e.PokemonFormId, e.PokeathlonStatId });

                entity.ToTable("pokemon_form_pokeathlon_stats");

                entity.Property(e => e.PokemonFormId).HasColumnName("pokemon_form_id");

                entity.Property(e => e.PokeathlonStatId).HasColumnName("pokeathlon_stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.Property(e => e.MaximumStat).HasColumnName("maximum_stat");

                entity.Property(e => e.MinimumStat).HasColumnName("minimum_stat");

                entity.HasOne(d => d.PokeathlonStat)
                    .WithMany(p => p.PokemonFormPokeathlonStats)
                    .HasForeignKey(d => d.PokeathlonStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonForm)
                    .WithMany(p => p.PokemonFormPokeathlonStats)
                    .HasForeignKey(d => d.PokemonFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonForms>(entity =>
            {
                entity.ToTable("pokemon_forms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormIdentifier)
                    .HasColumnName("form_identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.FormOrder).HasColumnName("form_order");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IntroducedInVersionGroupId).HasColumnName("introduced_in_version_group_id");

                entity.Property(e => e.IsBattleOnly)
                    .IsRequired()
                    .HasColumnName("is_battle_only")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("is_default")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.IsMega)
                    .IsRequired()
                    .HasColumnName("is_mega")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.HasOne(d => d.IntroducedInVersionGroup)
                    .WithMany(p => p.PokemonForms)
                    .HasForeignKey(d => d.IntroducedInVersionGroupId);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonForms)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonGameIndices>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionId });

                entity.ToTable("pokemon_game_indices");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonGameIndices)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonGameIndices)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonHabitatNames>(entity =>
            {
                entity.HasKey(e => new { e.PokemonHabitatId, e.LocalLanguageId });

                entity.ToTable("pokemon_habitat_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokemon_habitat_names_name");

                entity.Property(e => e.PokemonHabitatId).HasColumnName("pokemon_habitat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonHabitatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonHabitat)
                    .WithMany(p => p.PokemonHabitatNames)
                    .HasForeignKey(d => d.PokemonHabitatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonHabitats>(entity =>
            {
                entity.ToTable("pokemon_habitats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokemonItems>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionId, e.ItemId });

                entity.ToTable("pokemon_items");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonItems)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonMoveMethodProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonMoveMethodId, e.LocalLanguageId });

                entity.ToTable("pokemon_move_method_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokemon_move_method_prose_name");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonMoveMethodProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.PokemonMoveMethodProse)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonMoveMethods>(entity =>
            {
                entity.ToTable("pokemon_move_methods");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokemonMoves>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.VersionGroupId, e.MoveId, e.PokemonMoveMethodId, e.Level });

                entity.ToTable("pokemon_moves");

                entity.HasIndex(e => e.Level)
                    .HasName("ix_pokemon_moves_level");

                entity.HasIndex(e => e.MoveId)
                    .HasName("ix_pokemon_moves_move_id");

                entity.HasIndex(e => e.PokemonId)
                    .HasName("ix_pokemon_moves_pokemon_id");

                entity.HasIndex(e => e.PokemonMoveMethodId)
                    .HasName("ix_pokemon_moves_pokemon_move_method_id");

                entity.HasIndex(e => e.VersionGroupId)
                    .HasName("ix_pokemon_moves_version_group_id");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.MoveId).HasColumnName("move_id");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.HasOne(d => d.Move)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.MoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.PokemonMoves)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonShapeProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonShapeId, e.LocalLanguageId });

                entity.ToTable("pokemon_shape_prose");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokemon_shape_prose_name");

                entity.Property(e => e.PokemonShapeId).HasColumnName("pokemon_shape_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.AwesomeName)
                    .HasColumnName("awesome_name")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonShapeProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonShape)
                    .WithMany(p => p.PokemonShapeProse)
                    .HasForeignKey(d => d.PokemonShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonShapes>(entity =>
            {
                entity.ToTable("pokemon_shapes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<PokemonSpecies>(entity =>
            {
                entity.ToTable("pokemon_species");

                entity.HasIndex(e => e.ConquestOrder)
                    .HasName("ix_pokemon_species_conquest_order");

                entity.HasIndex(e => e.Order)
                    .HasName("ix_pokemon_species_order");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseHappiness).HasColumnName("base_happiness");

                entity.Property(e => e.CaptureRate).HasColumnName("capture_rate");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.ConquestOrder).HasColumnName("conquest_order");

                entity.Property(e => e.EvolutionChainId).HasColumnName("evolution_chain_id");

                entity.Property(e => e.EvolvesFromSpeciesId).HasColumnName("evolves_from_species_id");

                entity.Property(e => e.FormsSwitchable)
                    .IsRequired()
                    .HasColumnName("forms_switchable")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.GenderRate).HasColumnName("gender_rate");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GrowthRateId).HasColumnName("growth_rate_id");

                entity.Property(e => e.HabitatId).HasColumnName("habitat_id");

                entity.Property(e => e.HasGenderDifferences)
                    .IsRequired()
                    .HasColumnName("has_gender_differences")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.HatchCounter).HasColumnName("hatch_counter");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsBaby)
                    .IsRequired()
                    .HasColumnName("is_baby")
                    .HasColumnType("BOOLEAN");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.ShapeId).HasColumnName("shape_id");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EvolutionChain)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.EvolutionChainId);

                entity.HasOne(d => d.EvolvesFromSpecies)
                    .WithMany(p => p.InverseEvolvesFromSpecies)
                    .HasForeignKey(d => d.EvolvesFromSpeciesId);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.GenerationId);

                entity.HasOne(d => d.GrowthRate)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.GrowthRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Habitat)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.HabitatId);

                entity.HasOne(d => d.Shape)
                    .WithMany(p => p.PokemonSpecies)
                    .HasForeignKey(d => d.ShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesFlavorSummaries>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_flavor_summaries");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorSummary).HasColumnName("flavor_summary");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesFlavorSummaries)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesFlavorSummaries)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesFlavorText>(entity =>
            {
                entity.HasKey(e => new { e.SpeciesId, e.VersionId, e.LanguageId });

                entity.ToTable("pokemon_species_flavor_text");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PokemonSpeciesFlavorText)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PokemonSpeciesFlavorText)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PokemonSpeciesFlavorText)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesNames>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_pokemon_species_names_name");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Genus).HasColumnName("genus");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesNames)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonSpeciesProse>(entity =>
            {
                entity.HasKey(e => new { e.PokemonSpeciesId, e.LocalLanguageId });

                entity.ToTable("pokemon_species_prose");

                entity.Property(e => e.PokemonSpeciesId).HasColumnName("pokemon_species_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FormDescription).HasColumnName("form_description");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.PokemonSpeciesProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PokemonSpecies)
                    .WithMany(p => p.PokemonSpeciesProse)
                    .HasForeignKey(d => d.PokemonSpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonStats>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.StatId });

                entity.ToTable("pokemon_stats");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.BaseStat).HasColumnName("base_stat");

                entity.Property(e => e.Effort).HasColumnName("effort");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonStats)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.PokemonStats)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PokemonTypes>(entity =>
            {
                entity.HasKey(e => new { e.PokemonId, e.Slot });

                entity.ToTable("pokemon_types");

                entity.Property(e => e.PokemonId).HasColumnName("pokemon_id");

                entity.Property(e => e.Slot).HasColumnName("slot");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.PokemonTypes)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PokemonTypes)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RegionNames>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.LocalLanguageId });

                entity.ToTable("region_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_region_names_name");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.RegionNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionNames)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");
            });

            modelBuilder.Entity<StatNames>(entity =>
            {
                entity.HasKey(e => new { e.StatId, e.LocalLanguageId });

                entity.ToTable("stat_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_stat_names_name");

                entity.Property(e => e.StatId).HasColumnName("stat_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.StatNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.StatNames)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Stats>(entity =>
            {
                entity.ToTable("stats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.IsBattleOnly)
                    .IsRequired()
                    .HasColumnName("is_battle_only")
                    .HasColumnType("BOOLEAN");

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Stats)
                    .HasForeignKey(d => d.DamageClassId);
            });

            modelBuilder.Entity<SuperContestCombos>(entity =>
            {
                entity.HasKey(e => new { e.FirstMoveId, e.SecondMoveId });

                entity.ToTable("super_contest_combos");

                entity.Property(e => e.FirstMoveId).HasColumnName("first_move_id");

                entity.Property(e => e.SecondMoveId).HasColumnName("second_move_id");

                entity.HasOne(d => d.FirstMove)
                    .WithMany(p => p.SuperContestCombosFirstMove)
                    .HasForeignKey(d => d.FirstMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SecondMove)
                    .WithMany(p => p.SuperContestCombosSecondMove)
                    .HasForeignKey(d => d.SecondMoveId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SuperContestEffectProse>(entity =>
            {
                entity.HasKey(e => new { e.SuperContestEffectId, e.LocalLanguageId });

                entity.ToTable("super_contest_effect_prose");

                entity.Property(e => e.SuperContestEffectId).HasColumnName("super_contest_effect_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.FlavorText)
                    .IsRequired()
                    .HasColumnName("flavor_text");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.SuperContestEffectProse)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuperContestEffect)
                    .WithMany(p => p.SuperContestEffectProse)
                    .HasForeignKey(d => d.SuperContestEffectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SuperContestEffects>(entity =>
            {
                entity.ToTable("super_contest_effects");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Appeal)
                    .HasColumnName("appeal")
                    .HasColumnType("SMALLINT");
            });

            modelBuilder.Entity<TypeEfficacy>(entity =>
            {
                entity.HasKey(e => new { e.DamageTypeId, e.TargetTypeId });

                entity.ToTable("type_efficacy");

                entity.Property(e => e.DamageTypeId).HasColumnName("damage_type_id");

                entity.Property(e => e.TargetTypeId).HasColumnName("target_type_id");

                entity.Property(e => e.DamageFactor).HasColumnName("damage_factor");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.TypeEfficacyDamageType)
                    .HasForeignKey(d => d.DamageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TargetType)
                    .WithMany(p => p.TypeEfficacyTargetType)
                    .HasForeignKey(d => d.TargetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypeGameIndices>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.GenerationId });

                entity.ToTable("type_game_indices");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.GameIndex).HasColumnName("game_index");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.TypeGameIndices)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeGameIndices)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypeNames>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.LocalLanguageId });

                entity.ToTable("type_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_type_names_name");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.TypeNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeNames)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.ToTable("types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DamageClassId).HasColumnName("damage_class_id");

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.DamageClass)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.DamageClassId);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroupPokemonMoveMethods>(entity =>
            {
                entity.HasKey(e => new { e.VersionGroupId, e.PokemonMoveMethodId });

                entity.ToTable("version_group_pokemon_move_methods");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.PokemonMoveMethodId).HasColumnName("pokemon_move_method_id");

                entity.HasOne(d => d.PokemonMoveMethod)
                    .WithMany(p => p.VersionGroupPokemonMoveMethods)
                    .HasForeignKey(d => d.PokemonMoveMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.VersionGroupPokemonMoveMethods)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroupRegions>(entity =>
            {
                entity.HasKey(e => new { e.VersionGroupId, e.RegionId });

                entity.ToTable("version_group_regions");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.VersionGroupRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.VersionGroupRegions)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionGroups>(entity =>
            {
                entity.ToTable("version_groups");

                entity.HasIndex(e => e.Identifier)
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenerationId).HasColumnName("generation_id");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.VersionGroups)
                    .HasForeignKey(d => d.GenerationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VersionNames>(entity =>
            {
                entity.HasKey(e => new { e.VersionId, e.LocalLanguageId });

                entity.ToTable("version_names");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_version_names_name");

                entity.Property(e => e.VersionId).HasColumnName("version_id");

                entity.Property(e => e.LocalLanguageId).HasColumnName("local_language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR(79)");

                entity.HasOne(d => d.LocalLanguage)
                    .WithMany(p => p.VersionNames)
                    .HasForeignKey(d => d.LocalLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.VersionNames)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Versions>(entity =>
            {
                entity.ToTable("versions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("identifier")
                    .HasColumnType("VARCHAR(79)");

                entity.Property(e => e.VersionGroupId).HasColumnName("version_group_id");

                entity.HasOne(d => d.VersionGroup)
                    .WithMany(p => p.Versions)
                    .HasForeignKey(d => d.VersionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
