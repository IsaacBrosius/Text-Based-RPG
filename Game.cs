using System;

namespace Game {

    class Program3 {

        static void Main(string[] args) {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "Noob's First Console Game";

/***********************************************************************************************************************/// Variables

            int level = 1;

            int xp = 1;

            if (xp > (level * 3)) {
                level++;
                xp = 1;
            }

            string charName = "";

            string[] inventory = {"Health Potion", "Health Potion", "Health Potion", "", "Book: A Guide To Hexagonalism", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
            //30 slots

            string[] weapons = {"Small Knife", "Pokey Stick", "", "", "", "", "", "", "", "", "", ""}; //12 slots
            //
            //

            string equipedWeapon = "None";


            int weaponDamage = 0;

            string[] armor = {"", "", "", "", ""};//5 slots
            //Armor types: Light Elvish, Medium Elvish, Light Human, Medium Human, Heavy Human, Medium Ork, Heavy Ork, Really Heavy Ork. The birds can't wear armor.
            //Each armor type has a helmet, chestplate, leg guard, wrist guard, and footwear.

            int armorWeight = 0;

            string[] spells = {"Minor Heal", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};//15 slots

            string equipedSpell = "None";

            double health = 5 + (2 * level);

            double maxHealth = 5 + (2 * level);

            double strength = 3 + (level * 0.5);

            double damage = (3 + (level * 0.9)) + ((weaponDamage + strength) / 2);

            double speed = (5 + (level * 0.1)) - armorWeight;

            int spellsUsed = 0;

            int weaponsUsed = 0;

            int rangedUsed = 0;

            double spellAccuracy = 50 + (spellsUsed * (level / 3));

            if (spellAccuracy > 100) {
                spellAccuracy = 100;
            }

            double weaponAccuracy = 70 + (weaponsUsed * (level / 5));

            if (weaponAccuracy > 100) {
                weaponAccuracy = 100;
            }

            double rangedAccuracy = 60 + (rangedUsed * (level / 3));

            if (rangedAccuracy > 100) {
                rangedAccuracy = 100;
            }

            string attackType;

            string charType;

            string charClass;

            string charDesc;

            string itemToAdd;

            int gold = 10;

            bool attackSuccess;

/*************************************************************************************************************************************/// Commands

            void addSpell() {
                int i = 0;
                while (spells[i] != "") {
                    i++;
                }
                spells[i] = itemToAdd;
            }

            void addArmor() {
                int i = 0;
                while (armor[i] != "") {
                    i++;
                }
                armor[i] = itemToAdd;
            }
            void addWeapon() {
                int i = 0;
                while (weapons[i] != "") {
                    i++;
                }
                weapons[i] = itemToAdd;
            }

            void addInventory() {
                int i = 0;
                while (inventory[i] != "") {
                    i++;
                }
                inventory[i] = itemToAdd;
            }

            void removeItem() {
                Console.WriteLine("Type what you want to have removed. Type the EXACT name of the item, including capitol letters.");
                string remove = Console.ReadLine().ToString();;
                bool removed = false;
                bool done = false;
                int i = 0;

                while (done == false) {
                    if (inventory[i] == remove) {
                        inventory[i] = "";
                        removed = true;
                        done = true;
                    }
                    i++;

                    if (i >= inventory.Length) {
                        i = 0;
                        done = true;
                    }
                }

                if (removed == false) {
                    while (done == false) {
                        if (weapons[i] == remove) {
                            weapons[i] = "";
                            removed = true;
                            done = true;
                        }
                        i++;

                        if (i >= weapons.Length) {
                            i = 0;
                            done = true;
                        }
                    }
                }

                if (removed == false) {
                    while (done == false) {
                        if (spells[i] == remove) {
                            spells[i] = "";
                            removed = true;
                            done = true;
                        }
                        i++;

                        if (i >= spells.Length) {
                            i = 0;
                            done = true;
                        }
                    }
                }

                if (removed == false) {
                    while (done == false) {
                        if (armor[i] == remove) {
                            armor[i] = "";
                            removed = true;
                            done = true;
                        }
                        i++;

                        if (i >= armor.Length) {
                            i = 0;
                            done = true;
                        }
                    }
                }

                if (removed == false) {
                    Console.WriteLine(remove + " has not been removed. Maybe you mistyped it?");
                }

                else {
                    Console.WriteLine(remove + " has been removed.");
                }

            }//End removeItem

            void stats() {
                if (charName == "church" || charName == "Church") {
                rangedAccuracy = 0;
                }

                if (charName == "Caboose" || charName == "caboose") {
                    strength = 100 + (level * 0.5);
                }
                
                damage = (3 + (level * 0.9)) + ((weaponDamage + strength) / 2);
                
                Console.WriteLine("\nHealth: " + health + "\nStrength: " + strength + "\nDamage: " + damage + "\nSpeed: " + speed + "\n");
                Console.WriteLine("\nWeapon Accuracy: " + weaponAccuracy + "%" + "\nRanged Accuracy: " + rangedAccuracy + "%" + "\nSpell Accuracy: " + spellAccuracy + "%");
            }

           void showInventory() {
                Console.WriteLine("");
                int blankCount = 0;

                for (int i = 0; i < weapons.Length; i++) {
                    if (weapons[i] == "") {
                        blankCount++;
                    }
                }

                if(blankCount == weapons.Length) {
                    Console.WriteLine("You have no Weapons\n");
                }

                else {
                    int num = 1;
                    Console.WriteLine("Weapons: \n");
                    for (int i = 0; i < weapons.Length; i++) {
                        if (weapons[i] != "") {
                            Console.WriteLine(num + ". " + weapons[i]);
                            num++;
                        }
                    }
                }

                blankCount = 0;

                for (int i = 0; i < armor.Length; i++) {
                    if (armor[i] == "") {
                        blankCount++;
                    }
                }

                if (charType != "Bird") {
                     if (blankCount == armor.Length) {
                    Console.WriteLine("\nYou have no Armor");
                    }

                    else {
                        int num = 1;
                        Console.WriteLine("\nArmor: \n");
                        for (int i = 0; i < armor.Length; i++) {
                            if (armor[i] != "") {
                                Console.WriteLine(num + ". " + armor[i]);
                            }
                        }
                    }
                }

                else {
                    Console.WriteLine("\nYou can't have armor equiped, but here's what you have: \n");
                    if (blankCount == armor.Length) {
                        Console.WriteLine("Exactly nothing");
                    }

                    else {
                        int num = 1;
                        for (int i = 0; i < armor.Length; i++) {
                            if (armor[i] != "") {
                                Console.WriteLine(num + ". " + armor[i]);
                            }
                        }
                    }
                }

                blankCount = 0;

                for (int i = 0; i < armor.Length; i++) {
                    if (armor[i] == "") {
                        blankCount++;
                    }
                }

                if (blankCount == inventory.Length) {
                    Console.WriteLine("\nNo Misc Items\n");
                }

                else {
                    int num = 1;
                    Console.WriteLine("\nMisc Items: \n");
                    for (int i = 0; i < inventory.Length; i++) {
                        if (inventory[i] != "") {
                            Console.WriteLine(num + ". " + inventory[i]);
                        }
                    }
                    Console.WriteLine("");
                }
            }

            void attack() {
                Console.Clear();    
                Console.WriteLine("Attack!");

            }

            Random random = new Random();

            void testAttack() {
                int roll = random.Next(0, 101);

                if (attackType == "Spell") {
                    if (roll <= spellAccuracy) {
                        attackSuccess = true;
                    }

                    else {
                        attackSuccess = false;
                    }
                }

                if (attackType == "Weapon") {
                    if (roll <=  weaponAccuracy) {
                        attackSuccess = true;
                    }
                    else {
                        attackSuccess = false;
                    }
                }

                if (attackType == "Ranged") {
                    if (roll <= rangedAccuracy) {
                        attackSuccess = true;
                    }
                    else {
                        attackSuccess = false;
                    }
                }
            }

            void askForWeapon() {
                Console.WriteLine("\nWhat weapon do you want to use?");
                int num = 1;
                for (int i = 0; i < weapons.Length; i++) {
                    if (weapons[i] != "") {
                        Console.WriteLine(num + ". " + weapons[i]);
                        num++;
                    }
                }

                num = 1;

                string choice = Convert.ToString(Console.ReadLine());

                int choice2;

                bool success = Int32.TryParse(choice, out choice2); //Tries to convert what the user typed into a number

                bool done = false;

                bool found = false;

                int num2 = 1;

                if (success == false) {//If the user didn't type a number
                    while (done == false) {
                        for (int i = 0; i < weapons.Length; i++) {//Cycles through all items in "weapons"
                            if (weapons[i] == choice) {
                                found = true;
                                equipedWeapon = weapons[i];
                                done = true;
                            }
                            if (i == weapons.Length) {//Stops the loop if all the items in "weapons" were looked at
                                done = true;
                            }
                        }
                    }
                }

                else {
                    while (done == false) {
                        while (num2 <= num) {
                            for (int i = 0; i < weapons.Length; i++) {
                                if (weapons[i] != "") {
                                    num2++;
                                }
                                if (num2 == choice2) {//Check to see if item is what the user typed
                                    found = true;
                                    equipedWeapon = weapons[num2];
                                    done = true;
                                }
                            }
                            done = true; //If the loop finishes, but doesn't find the weapon
                        }
                    }

                    if (found == true) {
                        Console.WriteLine(equipedWeapon + " is now equiped.");
                        attackType = "Weapon";
                        enterClear();
                        attack();
                    }

                    if (done == true && found == false) {
                        Console.WriteLine("Weapon not found.");
                        enterClear();
                        askForWeapon();
                    }

                    else {
                        Console.WriteLine("Error");
                    }   

                }
                
            }

            void askForSpell() {
                Console.WriteLine("\nWhat spell do you want to use?");
                int num = 1;
                for (int i = 0; i < spells.Length; i++) {
                    if (spells[i] != "") {
                        Console.WriteLine(num + ". " + spells[i]);
                        num++;
                    }
                }

                string choice = Console.ReadLine();
            }

            void enterClear() {
                Console.WriteLine("\nPress Enter to move on.");
                string space = Console.ReadLine().ToString();
                if (space == "") {
                    Console.Clear();
                }
            }

            void checkCommand() {
                string comm = Console.ReadLine().ToString();

                if (comm == "i" || comm == "I" || comm == "inventory" || comm == "Inventory") {
                    showInventory();
                }

                if (comm == "s" || comm == "S" || comm == "stats" || comm == "Stats") {
                    stats();
                }

                if (comm == "r" || comm == "R" || comm == "Remove Item" || comm == "Remove item" || comm == "remove item" || comm == "Remove" || comm == "remove") {
                    removeItem();
                }

            }

/******************************************************************************************/// Restart function

            void restart() {
                Console.Clear();

/*********************************************************************************************************************/// ASking for character's type

                void askForCharType() {

                    Console.Clear();

                    Console.WriteLine("What race is your character? \nA: Ork \nB: Human \nC: Elf \nD: Bird Boi (I don't have a good name)");
                    string type = Console.ReadLine().ToString();

                    if (type == "ork" || type == "Ork" || type == "a" || type == "A") {
                        charType = "Ork";
                        health += 3;
                        damage += 3;
                        strength += 2;
                        speed -= 1;
                        itemToAdd = "Medium Ork Wrist Guards";
                        addArmor();
                        itemToAdd = "Medium Ork Footwear";
                        addArmor();
                        itemToAdd = "Medium Ork Chestplate";
                        addArmor();
                    }

                    else if (type == "human" || type == "Human" || type == "b" || type == "B") {
                        charType = "Human";
                        health += 2;
                        damage += 2;
                        strength += 2;
                        speed += 1;
                        itemToAdd = "Light Human Wrist Guards";
                        addArmor();
                        itemToAdd = "Light Human Footwear";
                        addArmor();
                        itemToAdd = "Light Human Chestplate";
                        addArmor();
                    }

                    else if (type == "Elf" || type == "elf" || type == "c" || type == "C") {
                        charType = "Elf";
                        health += 2;
                        damage += 1;
                        strength += 2;
                        speed += 4;
                        itemToAdd = "Light Elf Wrist Guards";
                        addArmor();
                        itemToAdd = "Light Elf Footwear";
                        addArmor();
                        itemToAdd = "Light Elf Chestplate";
                        addArmor();
                    }

                    else if (type == "D" || type == "d" || type == "bird boi" || type == "Bird boi" || type == "Bird Boi") {
                        charType = "Bird";
                        health += 5;
                        damage += 1;
                        strength += 2;
                        speed += 1;
                    }

                    else {
                        askForCharType();
                    }

                }

/*********************************************************************************************************************************/// Asking for character's class

                void askForCharClass() {

                    Console.Clear();

                    Console.WriteLine("What class is your character? \nA: Archer \nB: Warrior \nC: Mage \nD: Ninja");

                    string type = Console.ReadLine().ToString();

                    if (type == "Archer" || type == "archer" || type == "A" || type == "a") {
                        charClass = "Archer";
                        if (charName == "Griff" || charName == "griff" || charName == "grif" || charName == "Grif") {
                            itemToAdd = "The Grifshot";
                            addWeapon();
                        } 

                        else {
                            itemToAdd = charType + " Bow";
                            addWeapon();
                        }
                        
                    }

                    else if (type == "b" || type == "B" || type == "Warrior" || type == "warrior") {
                        charClass = "Warrior";
                        if (charName == "Tucker" || charName == "tucker") {
                            itemToAdd = "Energy Sword";
                            addWeapon();
                        }
                        else {
                            itemToAdd = charType + " Sword";
                            addWeapon();
                        };
                    }

                    else if (type == "c" || type == "C" || type == "mage" || type == "Mage") {
                        charClass = "Mage";
                        itemToAdd = "Fireball";
                        addSpell();
                    }

                    else if (type == "d" || type == "D" || type == "ninja" || type == "Ninja") {
                        charClass = "Ninja";
                        speed += 3;
                        itemToAdd = charType + "Shortsword";
                        addWeapon();
                    }

                    else {
                        askForCharClass();
                    }

                }

                Console.WriteLine("I'm gonna try to take you on an adventure. \nWhat's your character's name?");

                charName = Console.ReadLine().ToString();

                Console.WriteLine("Nice name... I think. I can't tell. I'm a program.");

                askForCharType();

                askForCharClass();

                charDesc = charName + " the " + charType + " " + charClass;

                Console.Clear();

                Console.WriteLine(charDesc + ". I like it. \n");

                Console.WriteLine("Before we go further, let's get you familiar with the commands.");

                enterClear();

/***********************************************************************************************************************/// Teaching Commands

                void commInventory() {

                    Console.WriteLine("Let's start with the Check Inventory command. \nPress \"I\", then Enter");

                    string check = Console.ReadLine().ToString();

                    if (check == "i" || check == "I" || check == "inventory" || check == "Inventory") {
                        showInventory();
                        Console.WriteLine("Nice going!");
                    }

                    else {
                        Console.WriteLine("Try again.");
                        commInventory();
                    }

                    enterClear();

                }

                commInventory();

                void commRemove() {

                    Console.WriteLine("Now for a command called \"Remove Item.\" You may have noticed some odd items.\n");
                    Console.WriteLine("Remove the item called \"Pokey Stick\" if you want. You may remove another item if you wish.");
                    Console.WriteLine("Type \"R\" then press Enter.");

                    string check = Console.ReadLine().ToString();

                    if (check == "r" || check == "R" || check == "remove item" || check == "Remove Item" || check == "Remove item") {
                        removeItem();
                    }

                    enterClear();

                }

                commRemove();

                void commStats() {

                    Console.WriteLine("You can check your stats like health, damage, strength, and speed by typing \"S\"");

                    string check = Console.ReadLine().ToString();

                    if (check == "s" || check == "S" || check == "stats" || check == "Stats") {
                        stats();
                        enterClear();
                    }

                }

                commStats();

/**************************************************************************************************************************///Teaching encounters

                void teachEncounter () {
                    Console.WriteLine("Now let's simulate a battle. Since you have chosen " + charClass + ", you have extra battle options.");

                    Console.WriteLine("\nA little boy walks up to you. He seem to be homeless. \n");

                    Console.WriteLine("A: Ask him where his parents are. (100%)");

                    if (charType != "Bird") {
                        Console.WriteLine("B: Walk away. (100%)");
                    }

                    else {
                        Console.WriteLine("B: Fly away. (100%)");
                    }

                    Console.WriteLine("C: Use weapon or spell. (" + weaponAccuracy + "% - " + spellAccuracy + "%)");

                    Console.WriteLine("D: Console child. (100%)");

                    string choice = Console.ReadLine();

                    if (choice == "a" || choice == "A") {
                        Console.Clear();
                        Console.WriteLine("\"They're around. Follow me.\"");

                    }

                    else if (choice == "b" || choice == "B") {
                        Console.Clear();
                        Console.WriteLine("\"Well that's rude,\" called the child.");
                        if (charType != "Bird") {
                            Console.WriteLine("As you walk away, you hear some chanting. What do you do?");
                        }
                        else {
                            Console.WriteLine("As you fly away, you hear some chanting. What do you do?");
                        }

                    }

                    else if (choice == "c" || choice == "C") {

                        void ask() {
                            Console.WriteLine("Weapon or spell? \nA: Weapon \nB: Spell");

                            string choice2 = Console.ReadLine();

                            if (choice2 == "weapon" || choice2 == "Weapon" || choice2 == "a" || choice2 == "A") {
                                askForWeapon();
                            }

                            else if (choice2 == "spell" || choice2 == "Spell" || choice2 == "b" || choice2 == "B") {
                                askForSpell();
                            }

                            else {
                                Console.WriteLine("Input not understood. Try again.");
                                ask();
                            }
                        }
                        ask();

                    }

                    else if (choice == "d" || choice == "D") {
                        Console.Clear();
                    }

                    else {
                        Console.WriteLine("Sorry, input not understood.");
                        enterClear();
                        teachEncounter();
                    }

                }

                teachEncounter();

            }//restart end

            restart();

            Console.WriteLine("Press Enter to restart.");
            string space = Console.ReadLine().ToString();
            if (space == "") {
                restart();
            }

            Console.ReadKey();
        }

    }

}