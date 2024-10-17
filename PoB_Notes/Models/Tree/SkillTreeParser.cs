using System.IO;
using System.Text.Json;
using PoB_NETRu.Models.Tree;
using System.Collections.ObjectModel;
using System;

public class SkillTreeParser
{
    public ObservableCollection<ClassAscendancy> ParseSkillTree(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Файл по пути {filePath} не найден.");
        }

        string jsonContent = File.ReadAllText(filePath);
        if (string.IsNullOrWhiteSpace(jsonContent))
        {
            throw new InvalidDataException("Файл пустой или содержит только пробелы.");
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var skillTree = JsonSerializer.Deserialize<SkillTree>(jsonContent, options);
        if (skillTree == null)
        {
            throw new JsonException("Не удалось десериализовать JSON в объект SkillTree.");
        }

        var classAscendancies = new ObservableCollection<ClassAscendancy>();

        foreach (var cls in skillTree.Classes)
        {

            foreach (var ascendancy in cls.Ascendancies)
            {
                var flavourTextRect = ascendancy.FlavourTextRect ?? new FlavourTextRect();

                classAscendancies.Add(new ClassAscendancy
                {
                    ClassName = cls.Name,
                    BaseStr = cls.Base_Str,
                    BaseDex = cls.Base_Dex,
                    BaseInt = cls.Base_Int,
                    AscendancyName = ascendancy.Name,
                    X = flavourTextRect.X,
                    Y = flavourTextRect.Y,
                    Width = flavourTextRect.Width,
                    Height = flavourTextRect.Height,
                    FlavourText = ascendancy.FlavourText
                });
            }
        }

        return classAscendancies;
    }
}
