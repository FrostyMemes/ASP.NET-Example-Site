using System;
using System.Linq;
using System.Net.Mime;

namespace FirstWeb.Domain.Entities.Repositories.Abstract
{
    public interface ITextItemsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}