using System;

namespace DataApp
{
    class Menu
    {
        public enum UserMenu
        {
            addUser = 1,
            showAllUsers = 2,
            choiceUser = 3,
            modifyUser = 4,
            modifyTask = 5,
            exit = 6
        }

        public enum UserChoice
        {
            showAllTaskOfUser = 1,
            addTaskUser = 2,
            completeUserTask = 3
        }

        public static void PrincipalMenu()
        {
            Console.WriteLine(
                        "1. Add user\n" +
                        "2. Show all users\n" +
                        "3. Choice user\n" +
                        "4. Modify user\n" +
                        "5. Modify task\n" +
                        "6. Exit from application\n");
        }
        public static void SubMenuUserChoice()
        {
            Console.WriteLine(
                        "1. All tasks\n" +
                        "2. Add task\n" +
                        "3. Complete task\n" +
                        "4. Main menu\n");
        }

        public static void MenuTextResult(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
        }

        public static UserMenu MenuChoice(int choice)
        {
            UserMenu userChoice = (UserMenu)choice;
            return userChoice;
        }

        public static UserChoice SubMenuChoice(int subChoice)
        {
            UserChoice subUserChoice = (UserChoice)subChoice;
            return subUserChoice;
        }
    }
}
