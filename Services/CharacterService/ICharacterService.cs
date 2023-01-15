
namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task <ServiceResponse<List<GetCharacterDto>>> List();
        Task <ServiceResponse<GetCharacterDto>> Get(int id);
        Task <ServiceResponse<List<GetCharacterDto>>> Add(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> Update(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> Delete(int id);
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
