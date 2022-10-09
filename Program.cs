// Задание 4
// Создайте класс «Веб-сайт». Необходимо хранить в 
// полях класса: название сайта, путь к сайту, описание 
// сайта, ip адрес сайта. Реализуйте методы класса для ввода 
// данных, вывода данных, реализуйте доступ к отдельным 
// полям через методы класса. 
// Задание 5
// Создайте класс «Журнал». Необходимо хранить в 
// полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
// Реализуйте методы класса для ввода данных, вывода 
// данных, реализуйте доступ к отдельным полям через 
// методы класса.
// Задание 6
// Создайте класс «Магазин». Необходимо хранить в 
// полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
// Реализуйте методы класса для ввода данных, вывода 
// данных, реализуйте доступ к отдельным полям через 
// методы класса.

using static System.Console;

// Класс "Сайт".
public class Web
{
    string? name;
    string? pathToWeb;
    string? aboutWeb;
    string? ipWeb;

    // Конструктор по умолчанию.
    public Web()
    {
        name = null;
        pathToWeb = null;
        aboutWeb = null;
        ipWeb = null;
    }

    // Конструктор с параметрами.
    public Web(string settingName, string settingPathToWeb, string settingAboutWeb, string settingIpWeb)
    {
        name = settingName;
        pathToWeb = settingPathToWeb;
        aboutWeb = settingAboutWeb;
        ipWeb = settingIpWeb;
    }

    // Получение полей класса.
    public string? returnName => name;

    public string? returnPathToWeb => pathToWeb; 

    public string? returnAboutWeb => aboutWeb; 

    public string? returnIpWeb => ipWeb; 
}

// Класс "Журнал".
public class Journal
{
    string? name;
    string? yearOfFoundation;
    string? aboutJournal;
    string? contactEmail;
    string? contactPhone;

    // Конструктор по умолчанию.
    public Journal()
    {
        name = null;
        yearOfFoundation = null;
        aboutJournal = null;
        contactEmail = null;
        contactPhone = null;
    }

    // Конструктор с параметрами.
    public Journal(string settingName, string settingYear, string settingAboutJournal, string settingEmail, string settingPhone)
    {
        name = settingName;
        yearOfFoundation = settingYear;
        aboutJournal = settingAboutJournal;
        contactEmail = settingEmail;
        contactPhone = settingPhone;
    }

    // Получение полей класса.
    public string? returnName => name;
    
    public string? ReturnYearOfFoundation => yearOfFoundation;

    public string? returnAboutJournal => aboutJournal; 

    public string? returnContactEmail => contactEmail;

    public string? returnContactPhone => contactPhone;
}

// Класс "Магазин".
public class Shop
{
    string? name;
    string? adress;
    string? aboutShop;
    string? contactEmail;
    string? contactPhone;

    // Конструктор по умолчанию.
    public Shop()
    {
        name = null;
        adress = null;
        aboutShop = null;
        contactEmail = null;
        contactPhone = null;
    }

    // Конструктор с параметрами.
    public Shop(string settingName, string settingAdress, string settingAboutShop, string settingEmail, string settingPhone)
    {
        name = settingName;
        adress = settingAdress;
        aboutShop = settingAboutShop;
        contactEmail = settingEmail;
        contactPhone = settingPhone;
    }

    // Получение полей класса.
    public string? returnName => name;

    public string? ReturnAdress => adress;

    public string? returnAboutShop => aboutShop;

    public string? returnContactEmail => contactEmail;

    public string? returnContactPhone => contactPhone;
    
}

public class Program
{
    public static void Main()
    {
        WriteLine("Hello, World!");
        
        Web web = new Web("Сайт1", "web1.com", "Просто сайт", "254.254.2.2");
        Write($"\nНазвание сайта: {web.returnName};\nПуть к сайту: {web.returnPathToWeb};\nО сайте: {web.returnAboutWeb};\nIp-адрес сайта: {web.returnIpWeb}.\n\n");

        Journal journal = new Journal("Журнал1", "2008", "Просто журнальчик", "zhurnalchik@mail.ru", "89087654321");
        Write($"\nНазвание журнала: {journal.returnName};\nГод создания журнала: {journal.ReturnYearOfFoundation};\nО журнале: {journal.returnAboutJournal};\nКонтактная электорнная почта: {journal.returnContactEmail};\nКонтактный телефон: {journal.returnContactPhone}.\n\n");

        Shop shop = new Shop("Магазин1", "Где-то", "Просто магазинчик", "magazinchik@mail.ru", "89087654321");
        Write($"\nНазвание магазина: {shop.returnName};\nАдрес магазина: {shop.ReturnAdress};\nО магазине: {shop.returnAboutShop};\nКонтактная электорнная почта: {shop.returnContactEmail};\nКонтактный телефон: {shop.returnContactPhone}.\n");
    }
}

