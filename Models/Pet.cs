using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel.Models
{
    public enum PetBreedType {
Affenpinscher,
Afghan_Hound,
Africanis,
Aidi,
Airedale_Terrier,
Akbash,
Akita,
Aksaray_Malaklisi,
Alano_Español,
Alapaha_Blue_Blood_Bulldog,
Alaskan_husky,
Alaskan_Klee_Kai,
Alaskan_Malamute,
Alopekis,
Alpine_Dachsbracke,
American_Bulldog,
American_bully,
American_Cocker_Spaniel,
American_English_Coonhound,
American_Eskimo_Dog,
American_Foxhound,
American_Hairless_Terrier,
American_Pit_Bull_Terrier,
American_Staffordshire_Terrier,
American_Water_Spaniel,
Andalusian_Hound,
Anglo_Français_de_Petite_Vénerie,
Appenzeller_Sennenhund,
Ariegeois,
Armant,
Armenian_Gampr_dog,
Artois_Hound,
Australian_Cattle_Dog,
Australian_Kelpie,
Australian_Shepherd,
Australian_Stumpy_Tail_Cattle_Dog,
Australian_Terrier,
Austrian_Black_and_Tan_Hound,
Austrian_Pinscher,
Azawakh,
Bakharwal_dog,
Banjara_Hound,
Barbado_da_Terceira,
Barbet,
Basenji,
Basque_Shepherd_Dog,
Basset_Artésien_Normand,
Basset_Bleu_de_Gascogne,
Basset_Fauve_de_Bretagne,
Basset_Hound,
Bavarian_Mountain_Hound,
Beagle,
Beagle_Harrier,
Belgian_Shepherd,
Bearded_Collie,
Beauceron,
Bedlington_Terrier,
Bergamasco_Shepherd,
Berger_Picard,
Bernese_Mountain_Dog,
Bichon_Frisé,
Billy,
Black_and_Tan_Coonhound,
Black_Norwegian_Elkhound,
Black_Russian_Terrier,
Black_Mouth_Cur,
Bloodhound,
Blue_Lacy,
Blue_Picardy_Spaniel,
Bluetick_Coonhound,
Boerboel,
Bohemian_Shepherd,
Bolognese,
Border_Collie,
Border_Terrier,
Borzoi,
Bosnian_Coarse_haired_Hound,
Boston_Terrier,
Bouvier_des_Ardennes,
Bouvier_des_Flandres,
Boxer,
Boykin_Spaniel,
Bracco_Italiano,
Braque_dAuvergne,
Braque_de_lAriège,
Braque_du_Bourbonnais,
Braque_Francais,
Braque_Saint_Germain,
Briard,
Briquet_Griffon_Vendéen,
Brittany,
Broholmer,
Bruno_Jura_Hound,
Brussels_Griffon,
Bucovina_Shepherd_Dog,
Bull_Arab,
Bull_Terrier,
Bulldog,
Bullmastiff,
Bully_Kutta,
Burgos_Pointer,
Buryat_Mongolian_Wolfhound,
Ca_Mè_Mallorquí,
Cairn_Terrier,
Campeiro_Bulldog,
Can_de_Chira,
Can_de_Palleiro,
Canaan_Dog,
Canadian_Eskimo_Dog,
Cane_Corso,
Cane_di_Oropa,
Cane_Paratore,
Cantabrian_Water_Dog,
Cão_da_Serra_de_Aires,
Cão_de_Castro_Laboreiro,
Cão_de_Gado_Transmontano,
Cão_Fila_de_São_Miguel,
Cardigan_Welsh_Corgi,
Carea_Castellano_Manchego,
Carea_Leonés,
Carolina_Dog,
Carpathian_Shepherd_Dog,
Catahoula_Leopard_Dog,
Catalan_Sheepdog,
Caucasian_Shepherd_Dog,
Cavalier_King_Charles_Spaniel,
Central_Asian_Shepherd_Dog,
Cesky_Fousek,
Cesky_Terrier,
Chesapeake_Bay_Retriever,
Chien_Français_Blanc_et_Noir,
Chien_Français_Blanc_et_Orange,
Chien_Français_Tricolore,
Chihuahua,
Chilean_Terrier,
Chinese_Crested_Dog,
Chinook,
Chippiparai,
Chongqing_dog,
Chortai,
Chow_Chow,
Chukotka_sled_dog,
Cimarrón_Uruguayo,
Cirneco_dellEtna,
Clumber_Spaniel,
Colombian_fino_hound,
Coton_de_Tulear,
Cretan_Hound,
Croatian_Sheepdog,
Curly_Coated_Retriever,
Cursinu,
Czechoslovakian_Wolfdog,
Dachshund,
Dalmatian,
Dandie_Dinmont_Terrier,
Danish_Spitz,
Danish_Swedish_Farmdog,
Denmark_Feist,
Dingo,
Dobermann,
Dogo_Argentino,
Dogo_Guatemalteco,
Dogo_Sardesco,
Dogue_Brasileiro,
Dogue_de_Bordeaux,
Drentse_Patrijshond,
Drever,
Dunker,
Dutch_Shepherd,
Dutch_Smoushond,
East_Siberian_Laika,
East_European_Shepherd,
Ecuadorian_Hairless_Dog,
English_Cocker_Spaniel,
English_Foxhound,
English_Mastiff,
English_Setter,
English_Shepherd,
English_Springer_Spaniel,
English_Toy_Terrier,
Entlebucher_Mountain_Dog,
Estonian_Hound,
Estrela_Mountain_Dog,
Eurasier,
Field_Spaniel,
Fila_Brasileiro,
Finnish_Hound,
Finnish_Lapphund,
Finnish_Spitz,
Flat_Coated_Retriever,
French_Bulldog,
French_Spaniel,
Galgo_Español,
Garafian_Shepherd,
Gascon_Saintongeois,
Georgian_Shepherd,
German_Hound,
German_Longhaired_Pointer,
German_Pinscher,
German_Roughhaired_Pointer,
German_Shepherd,
German_Shorthaired_Pointer,
German_Spaniel,
German_Spitz,
German_Wirehaired_Pointer,
Giant_Schnauzer,
Glen_of_Imaal_Terrier,
Golden_Retriever,
Gończy_Polski,
Gordon_Setter,
Grand_Anglo_Français_Blanc_et_Noir,
Grand_Anglo_Français_Blanc_et_Orange,
Grand_Anglo_Français_Tricolore,
Grand_Basset_Griffon_Vendéen,
Grand_Bleu_de_Gascogne,
Grand_Griffon_Vendéen,
Great_Dane,
Greater_Swiss_Mountain_Dog,
Greek_Harehound,
Greek_Shepherd,
Greenland_Dog,
Greyhound,
Griffon_Bleu_de_Gascogne,
Griffon_Fauve_de_Bretagne,
Griffon_Nivernais,
Gull_Dong,
Gull_Terrier,
Hällefors_Elkhound,
Halden_Hound,
Hamiltonstövare,
Hanover_Hound,
Harrier,
Havanese,
Himalayan_Sheepdog,
Hierran_Wolfdog,
Hokkaido,
Hovawart,
Huntaway,
Hygen_Hound,
Ibizan_Hound,
Icelandic_Sheepdog,
Indian_pariah_dog,
Indian_Spitz,
Irish_Red_and_White_Setter,
Irish_Setter,
Irish_Terrier,
Irish_Water_Spaniel,
Irish_Wolfhound,
Istrian_Coarse_haired_Hound,
Istrian_Shorthaired_Hound,
Italian_Greyhound,
Jack_Russell_Terrier,
Jagdterrier,
Japanese_Chin,
Japanese_Spitz,
Japanese_Terrier,
Jindo,
Jonangi,
Kai_Ken,
Kaikadi,
Kangal_Shepherd_Dog,
Kanni,
Karakachan_dog,
Karelian_Bear_Dog,
Kars,
Karst_Shepherd,
Keeshond,
Kerry_Beagle,
Kerry_Blue_Terrier,
Khala_,
King_Charles_Spaniel,
King_Shepherd,
Kintamani,
Kishu,
Kokoni,
Kombai,
Komondor,
Kooikerhondje,
Koolie,
Koyun_dog,
Kromfohrländer,
Kuchi,
Kuvasz,
Labrador_Retriever,
Lagotto_Romagnolo,
Lakeland_Terrier,
Lancashire_Heeler,
Landseer,
Lapponian_Herder,
Large_Münsterländer,
Leonberger,
Levriero_Sardo,
Lhasa_Apso,
Lithuanian_Hound,
Löwchen,
Lupo_Italiano,
Mackenzie_River_husky,
Magyar_agár,
Mahratta_Greyhound,
Maltese,
Manchester_Terrier,
Maneto,
Maremmano_Abruzzese_Sheepdog,
McNab_dog,
Miniature_American_Shepherd,
Miniature_Bull_Terrier,
Miniature_Fox_Terrier,
Miniature_Pinscher,
Miniature_Schnauzer,
Molossus_of_Epirus,
Montenegrin_Mountain_Hound,
Mountain_Cur,
Mountain_Feist,
Mucuchies,
Mudhol_Hound,
Mudi,
Neapolitan_Mastiff,
Nenets_Herding_Laika,
New_Guinea_singing_dog,
New_Zealand_Heading_Dog,
Newfoundland,
Norfolk_Terrier,
Norrbottenspets,
Northern_Inuit_Dog,
Norwegian_Buhund,
Norwegian_Elkhound,
Norwegian_Lundehund,
Norwich_Terrier,
Nova_Scotia_Duck_Tolling_Retriever,
Old_Croatian_Sighthound,
Old_Danish_Pointer,
Old_English_Sheepdog,
Old_English_Terrier,
Olde_English_Bulldogge,
Otterhound,
Pachon_Navarro,
Pampas_Deerhound,
Papillon,
Parson_Russell_Terrier,
Pastore_della_Lessinia_e_del_Lagorai,
Patagonian_Sheepdog,
Patterdale_Terrier,
Pekingese,
Pembroke_Welsh_Corgi,
Perro_Majorero,
Perro_de_Pastor_Mallorquin,
Perro_de_Presa_Canario,
Perro_de_Presa_Mallorquin,
Peruvian_Inca_Orchid,
Petit_Basset_Griffon_Vendéen,
Petit_Bleu_de_Gascogne,
Phalène,
Pharaoh_Hound,
Phu_Quoc_Ridgeback,
Picardy_Spaniel,
Plummer_Terrier,
Plott_Hound,
Podenco_Canario,
Podenco_Valenciano,
Pointer,
Poitevin,
Polish_Greyhound,
Polish_Hound,
Polish_Lowland_Sheepdog,
Polish_Tatra_Sheepdog,
Pomeranian,
Pont_Audemer_Spaniel,
Poodle,
Porcelaine,
Portuguese_Podengo,
Portuguese_Pointer,
Portuguese_Water_Dog,
Posavac_Hound,
Pražský_Krysařík,
Pshdar_dog,
Pudelpointer,
Pug,
Puli,
Pumi,
Pungsan_dog,
Pyrenean_Mastiff,
Pyrenean_Mountain_Dog,
Pyrenean_Sheepdog,
Rafeiro_do_Alentejo,
Rajapalayam,
Rampur_Greyhound,
Rat_Terrier,
Ratonero_Bodeguero_Andaluz,
Ratonero_Mallorquin,
Ratonero_Murciano,
Ratonero_Valenciano,
Redbone_Coonhound,
Rhodesian_Ridgeback,
Romanian_Mioritic_Shepherd_Dog,
Romanian_Raven_Shepherd_Dog,
Rottweiler,
Rough_Collie,
Russian_Spaniel,
Russian_Toy,
Russo_European_Laika,
Ryukyu_Inu,
Saarloos_Wolfdog,
Sabueso_Español,
Saint_Bernard,
Saint_Hubert_Jura_Hound,
Saint_Usuge_Spaniel,
Saluki,
Samoyed,
Sapsali,
Sarabi_dog,
Sardinian_Shepherd_Dog,
Šarplaninac,
Schapendoes,
Schillerstövare,
Schipperke,
Schweizer_Laufhund,
Schweizerischer_Niederlaufhund,
Scottish_Deerhound,
Scottish_Terrier,
Sealyham_Terrier,
Segugio_dellAppennino,
Segugio_Italiano,
Segugio_Maremmano,
Serbian_Hound,
Serbian_Tricolour_Hound,
Serrano_Bulldog,
Shar_Pei,
Shetland_Sheepdog,
Shiba_Inu,
Shih_Tzu,
Shikoku,
Shiloh_Shepherd,
Siberian_Husky,
Silken_Windhound,
Silky_Terrier,
Sinhala_Hound,
Skye_Terrier,
Sloughi,
Slovakian_Wirehaired_Pointer,
Slovenský_Cuvac,
Slovenský_Kopov,
Smalandstövare,
Small_Greek_domestic_dog,
Small_Münsterländer,
Smooth_Collie,
Smooth_Fox_Terrier,
Soft_Coated_Wheaten_Terrier,
South_Russian_Ovcharka,
Spanish_Mastiff,
Spanish_Water_Dog,
Spinone_Italiano,
Sporting_Lucas_Terrier,
Stabyhoun,
Staffordshire_Bull_Terrier,
Standard_Schnauzer,
Stephens_Stock,
Styrian_Coarse_haired_Hound,
Sussex_Spaniel,
Swedish_Elkhound,
Swedish_Lapphund,
Swedish_Vallhund,
Swedish_White_Elkhound,
Taigan,
Taiwan_Dog,
Tamaskan_Dog,
Tazy,
Teddy_Roosevelt_Terrier,
Telomian,
Tenterfield_Terrier,
Terrier_Brasileiro,
Thai_Bangkaew_Dog,
Thai_Ridgeback,
Tibetan_Kyi_Apso,
Tibetan_Mastiff,
Tibetan_Spaniel,
Tibetan_Terrier,
Torkuz,
Tornjak,
Tosa,
Toy_Fox_Terrier,
Toy_Manchester_Terrier,
Transylvanian_Hound,
Treeing_Cur,
Treeing_Feist,
Treeing_Tennessee_Brindle,
Treeing_Walker_Coonhound,
Trigg_Hound,
Tyrolean_Hound,
Vikhan,
Villano_de_Las_Encartaciones,
Villanuco_de_Las_Encartaciones,
Vizsla,
Volpino_Italiano,
Weimaraner,
Welsh_Sheepdog,
Welsh_Springer_Spaniel,
Welsh_Terrier,
West_Country_Harrier,
West_Highland_White_Terrier,
West_Siberian_Laika,
Westphalian_Dachsbracke,
Wetterhoun,
Whippet,
White_Shepherd,
White_Swiss_Shepherd_Dog,
Wire_Fox_Terrier,
Wirehaired_Pointing_Griffon,
Wirehaired_Vizsla,
Xiasi_Dog,
Xoloitzcuintle,
Yakutian_Laika,
Yorkshire_Terrier,
Zerdava,
        


    }
    public enum PetColorType {
        Brown,
        Red,
        Black,
        White,
        Gold,
        Yellow,
        Cream,
        Blue,
        Grey
    }
    public class Pet {
        public int id {get; set;}
        public string name {get; set;}
       
        public string color {get; set;}
        public string breed {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType type {get; set;}
        public PetColorType type {get; set;}

        [ForeignKey ("petOwner")]
         public int petOwnerId {get; set;}

         public PetOwner petOwner {get; set;}


    }
}
