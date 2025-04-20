﻿using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace RPNames
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Is the Debug on?")]
        public bool Debug { get; set; } = false;

        [Description("Should Tutorials have their nicknames as a name (true) or should they be hidden as a '???' (false)?")]
        public bool TutorialNick { get; set; } = true;

        [Description("Should Class-D be D-#### (true) or should it follow the other names with Title + Name (false)?")]
        public bool DboisSetting { get; set; } = true;

        [Description("Should SCPs have their SCP as a name (true) or should they be hidden as a '???' (false)?")]
        public bool scpSetting { get; set; } = false;

        [Description("Should a player be told their nickname?")]
        public bool ShowNick { get; set; } = true;

        [Description("Should a player have there real name after their nickname?")]
        public bool ShowRealName { get; set; } = false;
        
        [Description("Should a player have there id before their nickname?")]
        public bool ShowId { get; set; } = true;
        
        [Description("Should there be special nicknames for MTF?")]
        public bool DifferentNicknamesForMtf { get; set; } = false;
        
        [Description("Should there be special nicknames for Guard?")]
        public bool DifferentNicknamesForGuard { get; set; } = false;

        [Description("A dictionary with classes and their title")]
        public Dictionary<RoleTypeId, string> ClassTitles { get; set; } = new()
        {
            {
                RoleTypeId.ClassD, "D-"
            },
            {
                RoleTypeId.Scientist, "Dr."
            },
            {
                RoleTypeId.FacilityGuard, "Security Officer"
            },
            {
                RoleTypeId.NtfCaptain, "Commander"
            },
            {
                RoleTypeId.NtfPrivate, "Cadet"
            },
            {
                RoleTypeId.NtfSergeant, "Lieutenant"
            },
            {
                RoleTypeId.NtfSpecialist, "Field Agent"
            },
            {
                RoleTypeId.ChaosConscript, "Agent of Chaos"
            },
            {
                RoleTypeId.ChaosMarauder, "Agent of Chaos"
            },
            {
                RoleTypeId.ChaosRepressor, "Agent of Chaos"
            },
            {
                RoleTypeId.ChaosRifleman, "Agent of Chaos"
            },
            {
                RoleTypeId.Scp049, "SCP-049"
            },
            {
                RoleTypeId.Scp0492, "SCP-049-2"
            },
            {
                RoleTypeId.Scp079, "SCP-079"
            },
            {
                RoleTypeId.Scp096, "SCP-096"
            },
            {
                RoleTypeId.Scp106, "SCP-106"
            },
            {
                RoleTypeId.Scp173, "SCP-173"
            },
            {
                RoleTypeId.Scp939, "SCP-939"
            },
            {
                RoleTypeId.Tutorial, "???"
            }
        };

        [Description("The list of names to be given.")]
        public List<string> HumanFirstNames { get; set; } = new() { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Git", "Brook", "Broke", "Brown", "Smith", "Reed", "Freeman", "Guzman", "Simpson", "Gordan", "Silva", "Munoz", "Boyd", "Black", "Green", "Gray", "Purple", "Orange", "Apple", "Grapeseed", "Stone", "Meyer", "Schmidt", "Daniels", "Graza", "Soto", "Fox", "Hart", "Knight", "Night", "Cunningham", "Elliott", "Duncan", "Hudson", "Carroll", "Hoffman", "Pena", "Lawrence", "Chapman", "Rios", "Nunez", "Burke", "Maldonado", "Lawson", "O'brien", "Bishop", "Vega", "Le", "Bowman", "Davidson", "Brewer", "Newman", "Walsh", "Douglas", "Avila", "Bates", "Caldwell", "Lambert", "Neal", "Sutton", "Norris", "Rhodes", "Parks", "Vaughn", "Leon", "Horton", "Miles", "Warner", "Mann", "Zimmerman", "Dawson", "Lara", "Love", "Erickson", "Bladwin", "Salinas", "Ochoa", "Lin", "Liu", "Paul", "Ramsey", "Francis", "O'connor", "Pacheco", "Swanson", "Rivas", "Fitzgrald", "Gill", "Curry", "Mcgee", "Doyle", "Walton", "Brady", "Newton", "Goodman", "Roman", "Webster", "Fischer", "Potter", "Montoya", "Delacruz", "Adkins", "Reese", "Burgess", "Harmon", "Todd", "Wu", "Montoya", "Cannon", "Mack", "Tate", "Sherman", "Hubbard", "Hodges", "Zhang", "Zhang", "Wolf", "Valencia", "Saunders", "Franco", "Rowe", "Gallagher", "Farmer", "Hammond", "Townsend", "Hampton", "Wise", "Ingram", "Gallegos", "Clarke", "Barton", "Schroeder", "Maxwell", "Logan", "Norman", "Camacho", "Persons", "Colon", "Frank", "Glover", "Osborne", "Buchanan", "Casey", "Patton", "Ibarra", "Ball", "Tyler", "Suarez", "Bowers", "Orozco", "Salas", "Cobb", "Andrade", "Bauer", "Conner", "Moody", "Escobar", "Mcguire", "Pope", "McBride", "McCormick", "Lindsey", "Norton", "Kramer", "Sparks", "Flynn", "Yates", "Hogan", "Marsh", "Macias", "Villanueva", "Zamora", "Pratt", "Stokes", "Owen", "Ballard", "Lang", "Brock", "Villarreal", "Charles", "Drake", "Barrera", "Cain", "Patrick", "Pineda", "Burnett", "Mercado", "Santana", "Mercado", "Shepherd", "Bautista", "Ali", "Shaffer", "Lamb", "Trevino", "McKenzie", "Hess", "Beil", "Olsen", "Cochran", "Morton", "Nash", "Wilkins", "Peterson", "Briggs", "Shah", "Roth", "Nicholson", "Holloway", "Lozano", "Gambeno", "Flowers", "Rangel", "Hoover", "Short", "Mora", "Arias", "Valenzuela", "Bryan", "Meyers", "weilss", "Underwood", "Bass", "Summers", "Houston", "Carson", "Morrow", "Clayton", "Whitaker", "Decker", "Yoder", "Collier", "Zuniga", "Enes", "Wilcox", "Clayton", "Whitaker", "Melendez", "Poole", "Roberson", "Larsen", "Conley", "Davenport", "Copeland", "Massey", "Lam", "Huff", "Rocha", "Cameron", "Jefferson", "Hood", "Monroe", "Anthony", "Pittman", "Huynh", "Randall", "Singleton", "Kirk", "Combs", "Mathis", "Christian", "Skinner", "Bradford", "Richard", "Galvan", "Wall", "Boone", "Kirby", "Wilkinson", "Bridges", "Bruce", "Atkinson", "Velez", "Meza", "Roy", "Vincent", "York", "Hodge", "Villa", "Abbott", "Allison", "Tapia", "Gates", "Chase", "Sosa", "Sweeney", "Farrell", "Wyatt", "Horn", "Dalton", "Barron", "Phelps", "Yu", "Dickerson", "Heath", "Foley", "Atkins", "Mathews", "Bonilla", "Acevedo", "Benitez", "Zavala", "Hensley", "Glenn", "Cisneros", "Harrel", "Shields", "Rubio", "Huffman", "Choi", "Boyer", "Garrison" };
        
        [Description("The list of names to be given.")]
        public List<string> HumanLastNames { get; set; } = new() { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Git", "Brook", "Broke", "Brown", "Smith", "Reed", "Freeman", "Guzman", "Simpson", "Gordan", "Silva", "Munoz", "Boyd", "Black", "Green", "Gray", "Purple", "Orange", "Apple", "Grapeseed", "Stone", "Meyer", "Schmidt", "Daniels", "Graza", "Soto", "Fox", "Hart", "Knight", "Night", "Cunningham", "Elliott", "Duncan", "Hudson", "Carroll", "Hoffman", "Pena", "Lawrence", "Chapman", "Rios", "Nunez", "Burke", "Maldonado", "Lawson", "O'brien", "Bishop", "Vega", "Le", "Bowman", "Davidson", "Brewer", "Newman", "Walsh", "Douglas", "Avila", "Bates", "Caldwell", "Lambert", "Neal", "Sutton", "Norris", "Rhodes", "Parks", "Vaughn", "Leon", "Horton", "Miles", "Warner", "Mann", "Zimmerman", "Dawson", "Lara", "Love", "Erickson", "Bladwin", "Salinas", "Ochoa", "Lin", "Liu", "Paul", "Ramsey", "Francis", "O'connor", "Pacheco", "Swanson", "Rivas", "Fitzgrald", "Gill", "Curry", "Mcgee", "Doyle", "Walton", "Brady", "Newton", "Goodman", "Roman", "Webster", "Fischer", "Potter", "Montoya", "Delacruz", "Adkins", "Reese", "Burgess", "Harmon", "Todd", "Wu", "Montoya", "Cannon", "Mack", "Tate", "Sherman", "Hubbard", "Hodges", "Zhang", "Zhang", "Wolf", "Valencia", "Saunders", "Franco", "Rowe", "Gallagher", "Farmer", "Hammond", "Townsend", "Hampton", "Wise", "Ingram", "Gallegos", "Clarke", "Barton", "Schroeder", "Maxwell", "Logan", "Norman", "Camacho", "Persons", "Colon", "Frank", "Glover", "Osborne", "Buchanan", "Casey", "Patton", "Ibarra", "Ball", "Tyler", "Suarez", "Bowers", "Orozco", "Salas", "Cobb", "Andrade", "Bauer", "Conner", "Moody", "Escobar", "Mcguire", "Pope", "McBride", "McCormick", "Lindsey", "Norton", "Kramer", "Sparks", "Flynn", "Yates", "Hogan", "Marsh", "Macias", "Villanueva", "Zamora", "Pratt", "Stokes", "Owen", "Ballard", "Lang", "Brock", "Villarreal", "Charles", "Drake", "Barrera", "Cain", "Patrick", "Pineda", "Burnett", "Mercado", "Santana", "Mercado", "Shepherd", "Bautista", "Ali", "Shaffer", "Lamb", "Trevino", "McKenzie", "Hess", "Beil", "Olsen", "Cochran", "Morton", "Nash", "Wilkins", "Peterson", "Briggs", "Shah", "Roth", "Nicholson", "Holloway", "Lozano", "Gambeno", "Flowers", "Rangel", "Hoover", "Short", "Mora", "Arias", "Valenzuela", "Bryan", "Meyers", "weilss", "Underwood", "Bass", "Summers", "Houston", "Carson", "Morrow", "Clayton", "Whitaker", "Decker", "Yoder", "Collier", "Zuniga", "Enes", "Wilcox", "Clayton", "Whitaker", "Melendez", "Poole", "Roberson", "Larsen", "Conley", "Davenport", "Copeland", "Massey", "Lam", "Huff", "Rocha", "Cameron", "Jefferson", "Hood", "Monroe", "Anthony", "Pittman", "Huynh", "Randall", "Singleton", "Kirk", "Combs", "Mathis", "Christian", "Skinner", "Bradford", "Richard", "Galvan", "Wall", "Boone", "Kirby", "Wilkinson", "Bridges", "Bruce", "Atkinson", "Velez", "Meza", "Roy", "Vincent", "York", "Hodge", "Villa", "Abbott", "Allison", "Tapia", "Gates", "Chase", "Sosa", "Sweeney", "Farrell", "Wyatt", "Horn", "Dalton", "Barron", "Phelps", "Yu", "Dickerson", "Heath", "Foley", "Atkins", "Mathews", "Bonilla", "Acevedo", "Benitez", "Zavala", "Hensley", "Glenn", "Cisneros", "Harrel", "Shields", "Rubio", "Huffman", "Choi", "Boyer", "Garrison" };
        
        [Description("The list of names to be given.")]
        public List<string> MtfNames { get; set; } = new() { "Hyde", "Hood", "Hull", "Hogan", "Hitchens", "Higgins", "Hodder", "Huxx", "Hester", "King", "Kubiak", "Koker", "Kerrigan", "Kumara", "Knox", "Koufax", "Keagan", "Kestrel", "Future", "Fitzpatrick", "Fontana", "Fenner", "Furyk", "Finch", "Fullbright", "Fassbinder", "Flood", "Fong", "E.Gold", "Fleetwood", "Fugger", "Frost", "Fsik", "Fawcett", "Fishman", "Freeze", "Fissolo", "Foley", "Fairchild", "Freeman", "Decker", "Dobermann", "Dunlop", "Dumont", "Dandridge", "Diamond", "Cyrus", "Craggs", "Crisper", "Cotheran", "Curry", "Conard", "Cutler", "Coggins", "Cates", "Crisp", "Curio", "Murray", "Morrison", "McKay", "Merchant", "Murillo", "Mooney", "Murdock", "Matisse", "Massey", "McGee", "Minter", "Munson", "Oswald", "Ortega", "Ogle", "Orr", "Ogden", "Onassis", "Olson", "Ollenrenshaw", "Silver", "Small", "Stoneking", "Sweeney", "Surrett", "Swiatek", "Sloane", "Stapleton", "Seibert", "Stroud", "Strode", "Stockton", "Bright", "Miller", "Simarded", "Tombstone", "Cimmerian", "Conwell", "Clef", "Gears", "Kiryu", "Heiden", "Lloyd", "Marlowe", "Sorts", "Xyank", "Anborough", "LaFerrier", "Iceberg", "Kondraki", "Eskobar", "Anderson", "Ambrose", "Baudin", "Belitrov", "Chao", "Blackwood", "Fitzroy", "Silberescher", "Aktus", "Diaghilev", "Winchell", "Winters", "Walsh", "Whalen", "Watson", "Wooster", "Woodson", "Winthrop", "Wall", "Wight", "Webb", "Woodard", "Wixx", "Wong", "Whesker", "Wolfenstein", "Winchester", "Wire", "Wolf", "Wheeler", "Warrick", "Walcott", "Wilde", "Wexler", "Wells", "Weeks", "Wainright", "Wallace", "Weaver", "Wagner", "Wadd", "Withers", "Whitby", "Woodland", "Woody", "Warren", "Race", "Rooney", "Russo", "Rude", "Roland", "Reader", "Renshaw", "Rossi", "Riddle", "Ripa", "Richter", "Rosenberg", "Romo", "Ramirez", "Reagan", "Rainwater", "Romirez", "Riker", "Riggs", "Redman", "Reinhart", "Redgrave", "Rafferty", "Rigby", "Roman", "Reece", "Abawi", "Allard", "Adara", "Abbott", "Acampora", "Ackerman", "Ackroyd", "Abbington", "Axworthy", "Ainge", "Abernathy", "Atkinson", "Abner", "Abella", "Agholor", "Allred", "Asola", "Abrams", "Acker", "Abrell", "Acuff", "Archer", "Asterio", "Adair", "Albright", "Adelson", "Atwood", "Aguillar", "Adler", "Arrowood", "Arora", "Tray", "R.Tey", "A.Clef", "Amathor", "Jesus", "Joker", "Lemon", "Boucher", "Git", "Brook", "Broke", "Brown", "Smith", "Reed", "Freeman", "Guzman", "Simpson", "Gordan", "Silva", "Munoz", "Boyd", "Black", "Green", "Gray", "Purple", "Orange", "Apple", "Grapeseed", "Stone", "Meyer", "Schmidt", "Daniels", "Graza", "Soto", "Fox", "Hart", "Knight", "Night", "Cunningham", "Elliott", "Duncan", "Hudson", "Carroll", "Hoffman", "Pena", "Lawrence", "Chapman", "Rios", "Nunez", "Burke", "Maldonado", "Lawson", "O'brien", "Bishop", "Vega", "Le", "Bowman", "Davidson", "Brewer", "Newman", "Walsh", "Douglas", "Avila", "Bates", "Caldwell", "Lambert", "Neal", "Sutton", "Norris", "Rhodes", "Parks", "Vaughn", "Leon", "Horton", "Miles", "Warner", "Mann", "Zimmerman", "Dawson", "Lara", "Love", "Erickson", "Bladwin", "Salinas", "Ochoa", "Lin", "Liu", "Paul", "Ramsey", "Francis", "O'connor", "Pacheco", "Swanson", "Rivas", "Fitzgrald", "Gill", "Curry", "Mcgee", "Doyle", "Walton", "Brady", "Newton", "Goodman", "Roman", "Webster", "Fischer", "Potter", "Montoya", "Delacruz", "Adkins", "Reese", "Burgess", "Harmon", "Todd", "Wu", "Montoya", "Cannon", "Mack", "Tate", "Sherman", "Hubbard", "Hodges", "Zhang", "Zhang", "Wolf", "Valencia", "Saunders", "Franco", "Rowe", "Gallagher", "Farmer", "Hammond", "Townsend", "Hampton", "Wise", "Ingram", "Gallegos", "Clarke", "Barton", "Schroeder", "Maxwell", "Logan", "Norman", "Camacho", "Persons", "Colon", "Frank", "Glover", "Osborne", "Buchanan", "Casey", "Patton", "Ibarra", "Ball", "Tyler", "Suarez", "Bowers", "Orozco", "Salas", "Cobb", "Andrade", "Bauer", "Conner", "Moody", "Escobar", "Mcguire", "Pope", "McBride", "McCormick", "Lindsey", "Norton", "Kramer", "Sparks", "Flynn", "Yates", "Hogan", "Marsh", "Macias", "Villanueva", "Zamora", "Pratt", "Stokes", "Owen", "Ballard", "Lang", "Brock", "Villarreal", "Charles", "Drake", "Barrera", "Cain", "Patrick", "Pineda", "Burnett", "Mercado", "Santana", "Mercado", "Shepherd", "Bautista", "Ali", "Shaffer", "Lamb", "Trevino", "McKenzie", "Hess", "Beil", "Olsen", "Cochran", "Morton", "Nash", "Wilkins", "Peterson", "Briggs", "Shah", "Roth", "Nicholson", "Holloway", "Lozano", "Gambeno", "Flowers", "Rangel", "Hoover", "Short", "Mora", "Arias", "Valenzuela", "Bryan", "Meyers", "weilss", "Underwood", "Bass", "Summers", "Houston", "Carson", "Morrow", "Clayton", "Whitaker", "Decker", "Yoder", "Collier", "Zuniga", "Enes", "Wilcox", "Clayton", "Whitaker", "Melendez", "Poole", "Roberson", "Larsen", "Conley", "Davenport", "Copeland", "Massey", "Lam", "Huff", "Rocha", "Cameron", "Jefferson", "Hood", "Monroe", "Anthony", "Pittman", "Huynh", "Randall", "Singleton", "Kirk", "Combs", "Mathis", "Christian", "Skinner", "Bradford", "Richard", "Galvan", "Wall", "Boone", "Kirby", "Wilkinson", "Bridges", "Bruce", "Atkinson", "Velez", "Meza", "Roy", "Vincent", "York", "Hodge", "Villa", "Abbott", "Allison", "Tapia", "Gates", "Chase", "Sosa", "Sweeney", "Farrell", "Wyatt", "Horn", "Dalton", "Barron", "Phelps", "Yu", "Dickerson", "Heath", "Foley", "Atkins", "Mathews", "Bonilla", "Acevedo", "Benitez", "Zavala", "Hensley", "Glenn", "Cisneros", "Harrel", "Shields", "Rubio", "Huffman", "Choi", "Boyer", "Garrison" };

    }
}