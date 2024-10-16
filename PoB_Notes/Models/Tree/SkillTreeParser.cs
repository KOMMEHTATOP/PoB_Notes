using System;
using System.IO;
using System.Text.Json;  // Используется System.Text.Json
using PoB_NETRu.Models.Tree;

public class SkillTreeParser
{
    public SkillTree ParseSkillTree(string filePath)
    {
        // Проверка существования файла
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Файл по пути {filePath} не найден.");
        }

        // Чтение содержимого JSON-файла
        string jsonContent = File.ReadAllText(filePath);

        // Проверка на пустоту файла
        if (string.IsNullOrWhiteSpace(jsonContent))
        {
            throw new InvalidDataException("Файл пустой или содержит только пробелы.");
        }

        SkillTree skillTree;

        // Настройки для десериализации с игнорированием регистра
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true // Игнорировать регистр полей
        };

        try
        {
            // Парсинг с учетом настроек
            skillTree = JsonSerializer.Deserialize<SkillTree>(jsonContent, options);

            // Проверка на null после десериализации
            if (skillTree == null)
            {
                throw new JsonException("Не удалось десериализовать JSON в объект SkillTree.");
            }
        }
        catch (JsonException ex)
        {
            // Обработка ошибок при парсинге JSON
            throw new InvalidDataException("Ошибка при десериализации JSON: " + ex.Message);
        }

        // Возврат объекта дерева навыков
        return skillTree;
    }
}
