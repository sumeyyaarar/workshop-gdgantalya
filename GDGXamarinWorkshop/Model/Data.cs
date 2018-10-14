using System;
using System.Collections.Generic;

namespace GDGXamarinWorkshop.Model
{
    public class Data
    {
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string Image
        {
            get;
            set;
        }

        public static List<Data> Birds
        {
            get;
            set;
        }

        static Data()
        {
            Birds = new List<Data> {
               new Data
            {
                Name = "Quetzal",
                Description = "The resplendent quetzal is an aptly named bird that many consider among the world's most beautiful. These vibrantly colored animals live in the mountainous, tropical forests of Central America where they eat fruit, insects, lizards, and other small creatures. Unfortunately, these striking birds are threatened in Guatemala and elsewhere.",
                Image = "q.jpg"
                },
            new Data
            {
                Name = "The Rainbow Lorikeet",
                Description = "The Rainbow Lorikeet, (Trichoglossus haematodus) is a species of Australasian parrot found in Australia, eastern Indonesia (Maluku and Western New Guinea), Papua New Guinea, New Caledonia, the Solomon Islands and Vanuatu. In Australia, it is common along the eastern seaboard, from Queensland to South Australia and northwest Tasmania. Its habitat is rainforest, coastal bush and woodland areas. Several taxa traditionally listed as subspecies of the Rainbow Lorikeet are increasingly treated as separate species. There is little to visually distinguish between the sexes, however to a keen observer of their coloring and behavior, their dimorphism is readily apparent.",
                },
            new Data
            {
                Name = "Golden Pheasant",
                Description = "A truly magnificent sight, the Golden or Chinese Pheasant is another type of bird that catches the eye with a wonderful display of color. These are gamebirds, native to western China, although they have been bred in other countries like the UK, and are unmistakably lovely with a golden crest, rump and bright red body. When showing off to attract a mate, the male spreads his deep orange 'cape,' which looks just like a black and orange fan covering everything except the bright yellow eye. It is native to forests in mountainous areas of western China, but feral populations have been established in the United Kingdom and elsewhere.",
            },
            new Data
            {
                Name = "Bird of Paradise",
                Description = "The Birds of Paradise are members of the family Paradisaeidae of the order Passeriformes. The majority of species in this family are found on the island of New Guinea and its satellites, with a few species occurring in the Moluccas and eastern Australia. It's likely that you will only see them on film, though, because they mostly live in inaccessible, dense rainforest habitats..",
            },
                new Data
            {
                Name = "Atlantic Puffin",
                Description = "The Atlantic Puffin(Fratercula arctica) is a seabird species in the auk family.It is a pelagic bird that feeds primarily by diving for fish, but also eats other sea creatures, such as squid and crustaceans.Its most obvious characteristic during the breeding season is its brightly colored bill.Also known as the Common Puffin, it is the only puffin species which is found in the Atlantic Ocean.The curious appearance of the bird, with its large colorful bill and its striking piebald plumage, has given rise to nicknames such as clown of the ocean and sea rooster. The Atlantic Puffin is the provincial bird for the Canadian province of Newfoundland and Labrador.",
            },
                new Data
            {
                Name = "Lear's Macaw",
                Description = "The Lear's Macaw (Anodorhynchus leari), also known as the Indigo Macaw, is a large, all blue Brazilian parrot that is a member of a large group of Neotropical parrots known as macaws. It was first described by Charles Lucien Bonaparte in 1856. The Lear's Macaw is 70–75 cm. (28–30 in.) long and weighs around 950 g. (2.1 lb.). It is metallic blue with a faint, often barely visible tinge of green, and a yellow patch of skin at the base of the heavy, black bill. This macaw is rare with a highly restricted range.",
            },
                 new Data
            {
                Name = "Kingfishers",
                Description = "Stork-billed Kingfishers eat mainly fish, using their large heavy bills effectively to catch and kill their prey. From their perch, usually about 2-4 m. above the water, they will plunge into the water. They also eat crabs, insects, frogs, mice, lizards, and birds, along with their eggs. Prey is brought back and whacked senseless against the perch.They usually hunt near freshwater and along coasts and mangroves, particularly in habitats with suitable perches. Unlike the Collared, Stork-billed Kingfishers are rarely found near urban areas.",
            },
                 new Data
            {
                Name = "Peacocks",
                Description = "Peacocks are large, colorful pheasants (typically blue and green) known for their iridescent tails. These tail feathers, or coverts, spread out in a distinctive train that is more than 60 percent of the bird's total body length and boast colorful eye markings of blue, gold, red, and other hues. The large train is used in mating rituals and courtship displays. It can be arched into a magnificent fan that reaches across the bird's back and touches the ground on either side. Females are believed to choose their mates according to the size, color, and quality of these outrageous feather trains.",
            },
                 new Data
            {
                Name = "The male Northern Cardinal",
                Description = "The male Northern Cardinal may be responsible for getting more people to open up a field guide than any other bird. They're a perfect combination of familiarity, conspicuousness, and style: a shade of red you can't take your eyes off. Even the brown females sport a sharp crest and warm red accents. Cardinals don't migrate and they don't molt into a dull plumage, so they're still breathtaking in winter's snowy backyards. In summer, their sweet whistles are one of the first sounds of the morning.",
            },
                 new Data
            {
                Name = "The Grey Crowned Crane",
                Description = "The Grey Crowned Crane (Balearica regulorum) is a bird in the crane family Gruidae. It inhabits the dry African savannah south of the Sahara, although it nests in somewhat wetter habitats. They can also be found in marshes, cultivated areas and grassy flatlands near rivers and lakes from eastern Uganda and Kenya to South Africa. This animal does not migrate. There are two subspecies. The East African B. r. gibbericeps (Crested Crane) can be found from the eastern Democratic Republic of the Congo through Uganda, where it is the national bird, and from Kenya to eastern South Africa. It has a larger area of bare red facial skin above the white patch than the smaller nominate species, B. r. regulorum (South African Crowned Crane), which breeds from Angola down to South Africa.",
            },
                 new Data
            {
                Name = "The California Condor",
                Description = "The California Condor (Gymnogyps californianus) is a New World vulture, and the largest North American land bird. This condor inhabits northern Arizona and southern Utah (including the Grand Canyon area and Zion National Park), the coastal mountains of central and southern California, and northern Baja California. Although other fossil members are known, it is the only surviving member of the genus Gymnogyps.",
            },
            };
        }
    }
}
