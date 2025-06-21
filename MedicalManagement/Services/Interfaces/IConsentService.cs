using MedicalManagement.Models.DTOs;
using MedicalManagement.Models.Entities;

namespace MedicalManagement.Services.Interfaces
{
    public interface IConsentService
    {
        Task<List<ConsentReadDTO>> GetPendingConsentsAsync(int parentId);
        Task<List<ConsentReadDTO>> GetConsentHistoryAsync(int parentId);
        Task RespondToConsentAsync(int consentId, int parentId, ConsentActionDTO dto);
       
    }
}
