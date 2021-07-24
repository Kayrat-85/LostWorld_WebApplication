using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain
{
    public class DataManager
    {
        //свойства
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public IDinosaursPredatorsRepository DinosaursPredators { get; set; }
        public IDinosaursHerbivoresRepository DinosaursHerbivores { get; set; }
        public IDinosaursFlyingRepository DinosaursFlying { get; set; }
        public IDinosaursAquaticRepository DinosaursAquatic { get; set; }
        public IMammalsPredatorsRepository MammalsPredator { get; set; }
        public IMammalsHerbivoresRepository MammalsHerbivores { get; set; }
        public IAnthropogenesisRepository AnthropogenesisHumans { get; set; }

        //конструктор
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, 
            IDinosaursPredatorsRepository dinosaursPredatorsRepository, IDinosaursHerbivoresRepository dinosaursHerbivoresRepository, IDinosaursFlyingRepository dinosaursFlyingRepository,
            IDinosaursAquaticRepository dinosaursAquaticRepository, IMammalsPredatorsRepository mammalsPredatorsRepository, IMammalsHerbivoresRepository mammalsHerbivoresRepository,
            IAnthropogenesisRepository anthropogenesisRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            DinosaursPredators = dinosaursPredatorsRepository;
            DinosaursHerbivores = dinosaursHerbivoresRepository;
            DinosaursFlying = dinosaursFlyingRepository;
            DinosaursAquatic = dinosaursAquaticRepository;
            MammalsPredator = mammalsPredatorsRepository;
            MammalsHerbivores = mammalsHerbivoresRepository;
            AnthropogenesisHumans = anthropogenesisRepository;

        }
 
    }
}
