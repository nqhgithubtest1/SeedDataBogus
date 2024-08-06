using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeedData.Migrations
{
    public partial class BogusSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("11772746-d676-4046-8f16-d51d420afe98"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4b23fa81-784b-4b03-be59-4285b9b2d949"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4c73d08d-2157-4b8d-b4f9-d52528e3c8d6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("65197395-6baf-463b-8952-862efc23d831"));

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "MoTa", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("00ceaf09-8ec1-48ed-b5fa-faa455db91e9"), "Nulla molestiae accusantium maiores sed suscipit aperiam nostrum facere velit vel non non dolores quia non id nulla facilis rerum animi a et eaque fugit ut omnis aut sit quia sed quidem quo quos impedit aut ut ratione voluptate quis officiis in aut sapiente ut sunt tenetur sint provident omnis.", "Tasty Fresh Computer" },
                    { new Guid("0161fb24-8326-41e9-9384-b3a063aca590"), "Nisi quis nihil iusto nihil beatae dignissimos dolores temporibus soluta nostrum non quia explicabo saepe accusamus vero tenetur inventore eos voluptate fugit repellat culpa minus sapiente quae sunt tenetur commodi tenetur non ullam magni culpa et quos et aut cum consequatur sunt odit commodi autem quo ducimus voluptatem repellendus quia.", "Awesome Steel Bike" },
                    { new Guid("05a8d55c-80b5-4a55-9657-8aafe0a75f7d"), "Et consectetur odit consequatur ea et voluptatem rerum et molestiae ad fugiat qui tempora numquam fugit provident voluptatum culpa sed sit omnis in id est amet voluptate maxime velit suscipit sint et quaerat omnis consequuntur velit voluptatem quo soluta vel corporis id provident facilis sapiente qui quod molestias illum dolorum.", "Gorgeous Frozen Bike" },
                    { new Guid("05dc8c6d-8714-4e88-8e71-f595b546a97d"), "Eos vel quia illum facere impedit hic cum nihil unde dolorum vitae quia natus aut repudiandae nesciunt quasi voluptates impedit perspiciatis atque quia reiciendis qui exercitationem voluptas non exercitationem sed in nostrum quaerat et dolorem aut omnis molestiae tempora aut minima deleniti quas ut in et voluptatum unde illo magnam.", "Generic Steel Ball" },
                    { new Guid("08b66182-7878-4c3b-a0b2-753ca2263005"), "Amet nemo et dolores quia reiciendis consequatur dolores neque mollitia non molestiae enim quam sit accusantium eum animi nulla voluptatem accusamus aperiam sit eos est voluptate perferendis placeat ut ad ut quaerat hic alias a reprehenderit iure laudantium et et ex doloremque similique animi placeat quas minima aut et enim.", "Handcrafted Steel Chips" },
                    { new Guid("107643d6-d5c5-4d08-b138-af94748f0374"), "Hic at accusantium sed voluptatem quo maxime in magni sed molestiae quis optio quia omnis minus eum suscipit ipsa laudantium id quia laboriosam et temporibus sint et in voluptatem accusamus ea doloribus enim sunt esse impedit nostrum dignissimos dolore omnis provident est ipsum a eum a porro voluptatem ea aspernatur.", "Practical Rubber Car" },
                    { new Guid("11343ca8-4b59-4143-8715-158c8d1e0645"), "In cum blanditiis quaerat dolorum commodi tempora eius deserunt ab qui odio consectetur amet similique blanditiis cumque sunt molestias quos a expedita ea architecto molestias aut nisi consequatur libero quos voluptas esse id rerum et velit dolor perspiciatis ducimus illum expedita animi labore temporibus nostrum reprehenderit est sapiente sit ipsam.", "Handmade Plastic Shirt" },
                    { new Guid("13bb8a76-4ff4-4367-aaa2-6c9b96f86099"), "Omnis ipsum ut dolorem repellendus enim voluptatem natus autem illo vel itaque eveniet culpa deleniti mollitia odio est sit expedita quos fugiat et magnam dignissimos quibusdam ullam aut ipsum laborum et tenetur suscipit labore eius eligendi in ipsum natus natus et pariatur facilis a molestiae et veritatis eos eum vero.", "Incredible Metal Hat" },
                    { new Guid("13f51973-cfa6-4b96-ac15-5ebe45589331"), "Blanditiis fuga aut ducimus quis corporis minus dolorem odio laboriosam temporibus nulla repellendus doloribus sequi voluptatibus et deserunt nobis molestiae eos saepe aut deserunt ut sunt nam quas enim natus repellendus voluptas sunt vel quia voluptas consequatur minima error quaerat incidunt reprehenderit rem minima nihil corporis tempore atque voluptatem voluptatem.", "Handcrafted Fresh Bike" },
                    { new Guid("16f4e721-08fb-48ab-a27f-0eea1d432788"), "Illum veritatis corporis provident quidem aut sed non impedit aut totam voluptatibus ex enim tempora animi quos sapiente nesciunt dolor sapiente aliquid quod sapiente harum ut ipsam vel suscipit non iste ut aperiam laboriosam delectus sunt voluptatem quia amet aut id aut explicabo quo ut at dolores harum est excepturi.", "Small Metal Bacon" },
                    { new Guid("1c6f83f3-31ea-4e63-85a3-585f16e1dce0"), "Et dolorem et explicabo et sequi distinctio qui optio quia maxime suscipit minima facilis quidem voluptas quisquam nemo quae sapiente ad ut nisi saepe dicta aliquam consectetur dolores quo est dolores ut iure non eos laborum et provident et eum distinctio modi reiciendis qui exercitationem omnis ipsum dolorum odio accusamus.", "Refined Fresh Mouse" },
                    { new Guid("204dd7a6-6711-47bd-b517-432f92591055"), "Et et possimus repellendus ut esse nihil placeat reiciendis voluptas est labore quo id voluptate enim quidem non quis quia eaque asperiores minus et cumque culpa cupiditate repudiandae aut illo iste dolorum facere nostrum beatae suscipit non similique ratione cumque beatae ipsum perspiciatis ratione sint eum excepturi reprehenderit eligendi quas.", "Tasty Soft Mouse" },
                    { new Guid("2846d773-e529-4703-b462-891edf54d380"), "Ipsam natus consequuntur error qui non at vitae saepe quia necessitatibus soluta aut accusantium est id et non qui corrupti quo sequi quibusdam accusamus totam commodi quo quia ea aperiam quibusdam dignissimos rerum eum laboriosam ipsum nemo nisi ea sit delectus eos veritatis sint natus autem consequatur quae vero veniam.", "Intelligent Steel Pants" },
                    { new Guid("298c3997-435a-4c96-bc9f-39158f41d101"), "Voluptate et nam explicabo nisi itaque est neque est fugit tempore aspernatur alias et molestias exercitationem quasi omnis vel non voluptates aut explicabo dolorem similique similique corrupti a natus est officia dolorum qui in officia ex minus distinctio ut odit pariatur nulla at deserunt id quibusdam consequatur facere sapiente et.", "Fantastic Soft Salad" },
                    { new Guid("2cd0da05-5aa9-43b3-b93d-07f7c21502cf"), "Omnis accusantium occaecati sequi explicabo quidem sunt minima labore et animi minus nesciunt quod dicta omnis harum architecto dignissimos dolorem autem maiores magni qui non ex ipsam sed ipsum aliquid aut vero voluptatibus dolor iure consequatur tempora qui aut numquam placeat dolor eveniet hic nisi quo dolor deleniti quia odit.", "Intelligent Concrete Gloves" },
                    { new Guid("2ed5c08c-f28c-4554-91df-add9ad0d85ba"), "Libero et ea et et voluptatem omnis optio natus sit ducimus et rem rerum hic quaerat ut quibusdam vitae accusantium adipisci earum necessitatibus possimus itaque aut saepe tempore aut et voluptates aliquam quas eius et veritatis quaerat ea accusantium voluptas quis dolores et fugit rem non quia et dolore possimus.", "Intelligent Rubber Mouse" },
                    { new Guid("2fbfbc22-2747-4b94-9b9f-603961a7670a"), "Molestiae est a aliquam quia eos distinctio et quisquam rerum exercitationem sed et repellendus asperiores voluptas excepturi saepe error neque ut hic accusantium quia fugit quidem quibusdam et eligendi amet sunt sit fuga aliquid recusandae porro excepturi voluptatum eligendi sit perspiciatis maxime iure rerum quos sequi enim sed deserunt eius.", "Sleek Soft Ball" },
                    { new Guid("37f664d4-40e4-41c0-82f5-38ff18bd94d5"), "Cupiditate dicta voluptatibus minus consequatur reprehenderit laudantium ad eos doloribus neque totam fugit qui architecto cumque eum adipisci est est sint nihil qui dolore repellat ut velit minima eveniet saepe distinctio enim quia enim dolores laudantium similique odio voluptas assumenda aspernatur eum in et illo est nostrum eum doloremque corporis.", "Handmade Soft Sausages" },
                    { new Guid("394558b4-a606-46ad-85c6-4ff1ee117a1b"), "Dolores omnis deleniti blanditiis enim dolorem corporis ut enim eaque pariatur ad ea molestiae natus a perspiciatis eaque ipsa ea quidem dicta veritatis nesciunt vero dolore tempora eos dicta esse neque amet deleniti voluptatum quia dolorem expedita necessitatibus non maxime dolores pariatur numquam rem dolorem tempora ipsam assumenda omnis ut.", "Practical Concrete Table" },
                    { new Guid("3be5b71d-8e75-4c53-a657-d44746271499"), "Enim aut omnis rem quos dolorem consequatur exercitationem et rerum est aut sunt exercitationem enim quos ut aspernatur velit tempora est aut sed qui et nam illo rerum omnis perferendis sed perspiciatis voluptatem perspiciatis ipsum velit nisi ab maxime qui et eos delectus et aspernatur nam et ipsa praesentium qui.", "Sleek Steel Soap" },
                    { new Guid("3c3603bc-9c03-4754-ae61-81d2d985d0c6"), "Est consectetur est minima fugiat omnis natus repellat vero fugit a nulla facilis commodi rerum sit at repudiandae impedit sunt doloribus delectus et fugit reiciendis temporibus mollitia sed quidem blanditiis ab minima deleniti vero aperiam eligendi eius atque et autem quia sint ipsum tenetur veritatis nemo dignissimos alias quibusdam magni.", "Ergonomic Concrete Gloves" },
                    { new Guid("3e5444be-0de0-4365-a70c-777b2ae97cc5"), "Non sit quo voluptatibus cumque neque explicabo velit aut deserunt odit natus nisi quam quos assumenda veritatis pariatur non qui dolores qui ea vel qui perferendis iste sed eligendi rem id vel et eveniet nulla voluptatibus natus sunt tempora atque eligendi reprehenderit reiciendis reiciendis magnam sint odit dolores vitae animi.", "Incredible Cotton Salad" },
                    { new Guid("419ff539-41a3-49ee-bc2f-e98469498727"), "Esse molestias sed asperiores est esse dolorem est omnis doloremque debitis earum eos necessitatibus eveniet non reprehenderit iste veritatis possimus dicta iure ut quis illo corrupti omnis ut possimus quia aperiam necessitatibus qui aliquam cupiditate non fuga ut veritatis et repellat et dolores minus minima quis ut est accusantium possimus.", "Generic Fresh Car" },
                    { new Guid("42f118ae-930b-41f8-bedb-c0bcec853c19"), "Reprehenderit vero neque voluptas sit quo ad fugit beatae eos repudiandae voluptatem ut maiores et magni officia ipsa ipsa et quidem eos tempore exercitationem consectetur et et accusamus non nostrum delectus reprehenderit earum reiciendis nemo expedita consequatur harum et cupiditate rerum dolorum laudantium error sunt doloremque dolorum odio minima quis.", "Intelligent Steel Towels" },
                    { new Guid("4a129f2a-7559-4cbd-bae8-0b398094a2f4"), "Ut omnis autem rerum asperiores necessitatibus et saepe cumque voluptatem qui in porro voluptatum minima et omnis soluta iure ad et et natus sed voluptas fugit aut voluptatem quo ut quas quae voluptas beatae est ipsum placeat tempora maiores facilis eum sed aut esse nihil dolorem ea consectetur temporibus consequuntur.", "Rustic Concrete Bike" },
                    { new Guid("4a999f1a-b206-41be-b4b2-23d00ab866f7"), "Molestiae eligendi sed nisi veniam omnis incidunt quia laudantium quia eos beatae in voluptatem est impedit corrupti eius aut pariatur aliquam delectus ut explicabo et et quo culpa sint temporibus magnam error quae sint occaecati voluptas est animi aliquam et neque similique ducimus ut possimus molestias harum pariatur quia repudiandae.", "Tasty Frozen Chips" },
                    { new Guid("4c078e9e-8a68-4243-8f84-918a1faa622b"), "Reprehenderit sunt velit quibusdam minima animi itaque aut est fugit similique quidem qui ut libero doloribus est laboriosam ducimus tempora et et corrupti distinctio ut nisi est itaque hic repellat laudantium inventore unde quia rem excepturi corporis rem esse ut cupiditate nesciunt et quod sed rerum qui aspernatur minus nostrum.", "Handmade Fresh Computer" },
                    { new Guid("4d0dfdf1-1f9e-4fd6-8d5d-05106ca55e6c"), "Ut necessitatibus eveniet sapiente ab aliquid delectus et cumque enim nostrum facilis quos ut cupiditate consequatur aut et dignissimos amet mollitia amet veniam voluptatem perspiciatis est esse impedit perspiciatis sequi ducimus rerum aperiam minus ut suscipit fuga sit commodi maxime fugiat aliquam esse ea consequatur ad quod qui numquam laudantium.", "Handcrafted Wooden Tuna" },
                    { new Guid("4f8432d9-a3ec-4e75-9e9e-39dc3f84d8ea"), "Eum quia praesentium sit asperiores qui debitis exercitationem eos et dolores veniam qui non saepe magni maxime labore et cupiditate aut perferendis voluptate quia doloremque repudiandae quo necessitatibus minima vero voluptas enim expedita et qui facilis nam alias quis dicta quisquam dolorem distinctio atque eos labore non quidem iste debitis.", "Gorgeous Plastic Bacon" },
                    { new Guid("4fefaa17-1fe8-4920-b985-7af44cb65d91"), "Ut earum odio adipisci exercitationem a aut nesciunt aut sequi ut ipsum qui rem voluptatem qui quidem autem voluptatem suscipit nihil amet voluptate explicabo esse sit aliquid non assumenda delectus atque quibusdam expedita possimus voluptas harum optio cumque id impedit debitis voluptatibus excepturi sequi eos eveniet non velit autem dolorum.", "Incredible Frozen Towels" },
                    { new Guid("504f22d6-87fc-492c-910b-c3f5a041fa63"), "Porro quis excepturi quisquam temporibus pariatur dolore quam natus velit dolores sequi id dolore dolor voluptates maxime atque consequuntur sunt veritatis nesciunt eligendi nesciunt quaerat voluptatem expedita veniam corrupti saepe nemo fugit dicta sit ut laboriosam animi sequi aut est possimus sunt ex atque dolorem nisi neque debitis magni est.", "Awesome Wooden Ball" },
                    { new Guid("5523209a-2472-4558-80ae-a3e4328bbb68"), "Officiis omnis at quo voluptatibus eos molestias aliquid accusantium et libero dolore laudantium magnam eos ea voluptates voluptatem corrupti est voluptatem ut quod at fugiat et cupiditate animi fugiat eveniet non ut cupiditate blanditiis aut neque unde fuga perferendis quod quis enim debitis fugiat eos omnis numquam aut maxime nemo.", "Handcrafted Frozen Soap" },
                    { new Guid("584eb7df-27df-47f4-820d-7a74a35625bc"), "Vitae ex et minima rerum est accusantium praesentium corrupti ut voluptatem ea soluta aut et excepturi culpa quae cumque enim facilis at ullam quo eligendi sit delectus est et blanditiis explicabo quia cupiditate nihil hic officiis est rem nemo libero et quisquam ex explicabo aut voluptate praesentium rerum iure nostrum.", "Handmade Fresh Keyboard" },
                    { new Guid("5c971414-db4f-4d6f-9b7b-7566efe0d849"), "Ea quia rerum ad alias non dolorum aut at non expedita dolore et nihil odio esse tempora eos vitae quibusdam ea debitis qui omnis assumenda est enim odit nisi ut nulla explicabo eligendi ipsum non velit dignissimos quas veniam accusamus quae optio reprehenderit cupiditate tempora et commodi harum porro vel.", "Tasty Metal Keyboard" },
                    { new Guid("5c9e963b-0527-4932-96a2-7ae92dc2295c"), "Ut cupiditate eum saepe cum et quo omnis quo quis repellat rerum quae qui quas numquam placeat delectus aspernatur asperiores quis qui ut vero inventore modi voluptatem sit non et necessitatibus voluptates libero qui veritatis consectetur tenetur non rerum quas occaecati consequuntur nihil deserunt minus non dolorum accusamus et dignissimos.", "Gorgeous Cotton Chair" },
                    { new Guid("5d54dc05-01e4-4bb0-b753-cae71df3e254"), "Omnis quos et sint dignissimos dolore quam eaque voluptate nisi aliquid mollitia vitae quam occaecati necessitatibus quibusdam repellat quibusdam enim illo et dicta qui aut sed unde ratione eum corporis qui labore modi sint qui sunt nostrum aliquid neque consectetur mollitia a quidem doloribus id omnis ut cumque fugit reprehenderit.", "Handcrafted Frozen Chicken" },
                    { new Guid("6a824102-c9ee-4284-9bfc-430b3c2f4460"), "Quis ullam est placeat et consequatur veniam dolorem itaque dignissimos eius quibusdam officiis saepe voluptate sequi itaque asperiores eos quod cumque consequatur nobis tenetur repellat voluptas accusantium repudiandae quisquam fugit ut reiciendis aut dolorum alias eos ut placeat illo corporis nihil cum magni aspernatur cum quam rerum est sequi ut.", "Gorgeous Steel Soap" },
                    { new Guid("6aca9bf0-9678-45aa-bcc7-bec555356656"), "Fugit quo aliquid pariatur adipisci neque optio similique sint earum aliquid reiciendis dolor adipisci delectus rem magnam maxime officia earum ut soluta deleniti ea minus deleniti omnis quidem consequuntur enim excepturi expedita et minus aliquam eos expedita qui corporis sed quasi unde sed vel id minus ex aut laborum perspiciatis.", "Sleek Soft Tuna" },
                    { new Guid("6d63e96e-84f3-40a1-b954-7c71a4e923d1"), "Omnis ipsa sequi tempora aut odit id recusandae aut dolores porro vitae molestiae cum rem fugiat enim tempore assumenda neque ad vitae quaerat exercitationem nulla deleniti omnis non architecto et deserunt ut accusamus eos laborum soluta dolore minima dolore quia commodi harum odit repellendus amet sit necessitatibus quia aut explicabo.", "Ergonomic Soft Keyboard" },
                    { new Guid("75fdae46-59f5-459f-9ddf-6880f05c0228"), "Qui ducimus itaque earum aliquam sint commodi aut nihil quis labore qui odio saepe unde voluptas qui pariatur optio et molestiae eaque impedit nam dolorum qui repudiandae eveniet itaque harum officiis tempora rerum iste illo harum ipsa nemo ut non molestiae occaecati autem dolor accusantium soluta eaque autem natus omnis.", "Awesome Wooden Chips" },
                    { new Guid("76f70682-ca8f-45c2-80ac-24555f08eab5"), "Quia qui quidem autem est a quidem sit voluptatem et praesentium eos temporibus molestiae sed et rerum consequuntur quo recusandae qui officia quia asperiores similique veniam quis mollitia repudiandae voluptas quas ducimus non quasi nihil dolore delectus consequatur nihil qui ipsam rerum qui est veritatis commodi id fugiat reprehenderit sed.", "Sleek Metal Chair" },
                    { new Guid("7a9e529b-15f6-4cb0-a106-c7d2ab09e962"), "Et molestiae voluptatum soluta sed nihil ut maiores sit ad ut quam minus sit facere nihil qui saepe animi voluptas voluptates et consequatur quo quos est quam et aliquam in sunt id sit itaque et voluptatibus quam aliquam ea dicta et consequatur architecto voluptas qui praesentium eaque voluptas illo velit.", "Unbranded Metal Salad" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "MoTa", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("7deb7d53-8832-4413-b5d3-0115940bf14d"), "Quas voluptatem voluptatum enim numquam modi veniam omnis ut laborum consequatur illum suscipit labore adipisci et ea delectus quos aperiam exercitationem et iure facere laboriosam consequatur beatae hic accusantium molestias id sed odit nesciunt placeat consequatur reprehenderit dolor similique doloribus repudiandae hic a itaque tempore voluptas sint unde consequuntur ut.", "Gorgeous Wooden Pizza" },
                    { new Guid("80e9591d-ce73-4ae3-b9e2-916cce7b370a"), "Quia est vel expedita sit mollitia velit velit dolores dolorem provident eum quod sit omnis est omnis omnis enim corrupti minus enim necessitatibus ducimus omnis ut consectetur sit totam ratione debitis sint aspernatur debitis aliquam vero quia sapiente nam commodi ducimus sit consequatur voluptatum animi quidem ratione esse amet consequatur.", "Handcrafted Concrete Fish" },
                    { new Guid("82373d86-a9a2-431b-823a-ac91011ebdda"), "Pariatur quia omnis quaerat error praesentium quam eos commodi sequi recusandae magni rerum nulla tempora incidunt aut magnam eum ut placeat officiis quaerat a est et aliquam sit ut culpa voluptas repellendus labore voluptatem iusto excepturi qui a maiores iure quia quibusdam quaerat veritatis nihil maiores accusantium commodi et accusamus.", "Practical Concrete Table" },
                    { new Guid("82e2ccd0-c1ab-4d51-ad7b-b1a4c44263c3"), "Eos est facilis maiores voluptas consectetur quaerat aliquam dolorem incidunt aut voluptas laboriosam laborum voluptas expedita voluptas officia suscipit enim totam cupiditate et sed delectus vero quia ea voluptates sit voluptates iste consequatur rerum qui architecto aut ea tenetur voluptatem et itaque et saepe aut qui impedit quo nulla vel.", "Licensed Wooden Hat" },
                    { new Guid("845dd74e-2f0b-416b-8337-3da61a299ff6"), "Aut voluptates qui consequatur sapiente consectetur cum fugit sunt aut adipisci necessitatibus eveniet sed velit facere rerum magnam et molestiae quam quas est nobis nesciunt minus quaerat delectus autem harum qui rerum occaecati quas ut voluptatem ea et qui molestiae dolor et ex quo vero quia quae error veritatis necessitatibus.", "Ergonomic Concrete Keyboard" },
                    { new Guid("84d70e4b-f593-48f9-b3a7-2532a4735739"), "Est ab mollitia et qui quia asperiores ad mollitia in nesciunt laborum fuga quisquam enim dolores sunt sunt sint iure optio nobis et exercitationem est sunt quos dolor molestiae maxime sint consequatur blanditiis necessitatibus officia aut quis vel natus exercitationem maiores dignissimos iusto accusamus non et est est eius reprehenderit.", "Tasty Concrete Tuna" },
                    { new Guid("8bdc645a-cbb1-4cf3-a2d7-d18359ae6b30"), "Qui blanditiis distinctio culpa omnis earum quia corrupti deserunt sequi et id aut qui qui est quo commodi et ea voluptatem itaque soluta veritatis dolore commodi aut minus aut debitis qui aspernatur rerum maiores consequatur sit quam suscipit aut nulla laborum ratione nihil soluta et placeat error blanditiis eligendi voluptatum.", "Tasty Frozen Towels" },
                    { new Guid("8c2d7c57-3637-4801-8f7a-aff5cf27abe2"), "Et excepturi qui sunt aliquid ut omnis et eum sed et tempore libero in tenetur numquam aut veritatis ea eveniet laudantium fugiat quis iusto dolorem qui quia consequatur pariatur magnam officia exercitationem laborum enim exercitationem quo et eaque odio modi impedit nam incidunt velit ab at quas qui sit ipsam.", "Intelligent Concrete Mouse" },
                    { new Guid("8e6fc044-525d-406a-9ffe-e36522b8ac22"), "Maiores quae in minima qui molestias harum temporibus necessitatibus eum nam nulla et laborum nisi eius ipsam eos inventore consequatur similique dolore et nesciunt nisi et suscipit iste officiis quia accusamus cumque laboriosam dolor quam est eum consequatur ut libero nemo vel impedit impedit velit sint qui at quas veniam.", "Gorgeous Rubber Computer" },
                    { new Guid("926bc23b-0d64-4f65-9662-8c221adf8709"), "Maxime ut optio enim et omnis rerum possimus vero accusamus a non qui doloribus sed ipsa assumenda rem id voluptas ut at officia mollitia perferendis velit sunt asperiores tempore esse voluptatum repellendus natus quos et nesciunt maiores et eos voluptatem facere molestiae et dignissimos molestiae aut ut et et et.", "Sleek Plastic Keyboard" },
                    { new Guid("996ae7f7-0dbe-4e8e-894c-16ca6d5f2066"), "Et cupiditate quia provident quaerat est ipsum laboriosam hic officiis consectetur perferendis nihil voluptatibus tenetur pariatur possimus pariatur non voluptatibus non aut aut blanditiis esse minima eum magnam autem consequuntur quia rem non natus iste iure mollitia sed aliquam minima dolorum natus quo voluptates et cumque amet iste consequuntur maiores.", "Ergonomic Soft Soap" },
                    { new Guid("a0d7ce1d-f6a0-4549-bf66-6c68a10ad345"), "Nemo minima delectus et sed expedita nesciunt cumque architecto non fugit assumenda quis suscipit incidunt totam perspiciatis cum ex recusandae quis fugiat autem et animi ad molestias doloribus nostrum delectus corrupti eius dolores accusamus iste id neque ut possimus qui quisquam in enim omnis iusto minima velit voluptas doloremque velit.", "Unbranded Rubber Hat" },
                    { new Guid("a29810b3-86fa-4efc-8bdc-8c16c2df4c44"), "Beatae non nihil ut voluptas similique tenetur deleniti non et necessitatibus et quis nisi vel iste inventore beatae voluptatem ab et doloremque quasi laboriosam in neque sed qui molestiae dolore delectus tempore voluptatem quia et placeat autem eligendi rerum atque et tempore occaecati aut quia atque quas architecto praesentium et.", "Handcrafted Cotton Computer" },
                    { new Guid("a554a621-4de3-46df-9a05-29cecc484b4f"), "Autem est minima quis eos animi mollitia aliquid aut quasi recusandae itaque ipsum eligendi voluptatibus dolor rerum ipsam incidunt reprehenderit sunt delectus odio provident esse qui optio et sed corrupti qui qui veniam eius facere neque quas quo consequatur temporibus unde assumenda voluptatibus saepe corrupti est culpa sit doloribus aut.", "Ergonomic Metal Computer" },
                    { new Guid("a5a72697-7641-4863-a6e3-dcc86176c0ab"), "Quia ut dignissimos perspiciatis hic earum et voluptatum accusamus aliquid quos delectus officiis blanditiis esse non incidunt ut totam autem adipisci repudiandae facere beatae doloremque quia eligendi ut corrupti est amet iste nesciunt velit dolore laboriosam sit nostrum accusantium corrupti perspiciatis ipsum ut unde veniam assumenda a deserunt voluptates rerum.", "Sleek Wooden Table" },
                    { new Guid("a61c7f37-d13f-4947-9d33-124a56391ca6"), "In tenetur consequuntur animi omnis consequatur esse id est exercitationem ducimus est quis totam quibusdam suscipit voluptate temporibus tenetur omnis aspernatur facere in dignissimos ducimus officia ullam id eos hic sint ea aperiam saepe ex distinctio est non nobis sunt illo aperiam in cumque in eligendi inventore natus accusantium necessitatibus.", "Tasty Rubber Pizza" },
                    { new Guid("a6dd5f1b-4f15-462e-b07c-4b9b75fe9803"), "Quia rem voluptatem eius dolore rerum voluptatem ea aut incidunt laborum quae iusto omnis fugiat nihil repellendus minus in et doloremque tempore exercitationem ipsa error id voluptates debitis soluta laboriosam voluptatibus tempore corrupti dignissimos dolorum corrupti cum sed amet id dolorum eaque libero in iste eos quasi omnis accusantium at.", "Handmade Fresh Bike" },
                    { new Guid("a80b248d-80f7-48f8-90f9-6c59b6693094"), "Libero tempora consequatur reiciendis temporibus maiores tenetur fugit hic in est necessitatibus totam quaerat nemo nam et et consequatur ea mollitia doloribus quo hic architecto asperiores explicabo eaque officia architecto voluptatem ducimus ea quae sunt non eaque officia placeat dolore autem soluta consequuntur placeat quasi voluptas qui quis fuga facilis.", "Unbranded Rubber Keyboard" },
                    { new Guid("aaf4ed9d-140c-462a-bcfc-da223f2d365e"), "Deserunt molestiae quia beatae et voluptas quaerat id beatae perferendis numquam molestias aut aut sint non suscipit ab doloribus aut autem mollitia et recusandae quia et qui fugit repellat distinctio quidem quos sed est aut cupiditate nam rerum soluta delectus illum aut corporis dolores magni dolore voluptatem velit et reiciendis.", "Incredible Cotton Bacon" },
                    { new Guid("aafe8bd6-4c77-47ac-9b82-8859c988f54d"), "Est qui recusandae repudiandae voluptatem itaque maxime voluptatum eligendi aliquam nobis aut mollitia numquam et consequuntur et dolorem tempora est autem accusantium sunt cum voluptate expedita amet sequi placeat est fugit omnis facilis qui perspiciatis voluptatibus ea reprehenderit ipsa et ipsam doloremque sapiente eveniet debitis laborum omnis atque minima qui.", "Tasty Plastic Gloves" },
                    { new Guid("abb0f9b9-7616-409c-8f8f-f17d3d078268"), "Suscipit sunt rerum praesentium ut officia reiciendis provident aut nihil vero nam eveniet id quisquam est a ut iusto non et nemo sint voluptas ut omnis natus autem aperiam molestiae aut distinctio vel suscipit reprehenderit aut aut dolor in odit et sed animi voluptatem atque laudantium officiis vel consequatur qui.", "Handcrafted Granite Keyboard" },
                    { new Guid("ad83ba3e-8a6f-402f-8c10-2618b59b5855"), "Aspernatur aut ut beatae sed doloremque fuga ut ut et ad et voluptas rerum voluptatem eum enim nisi ut nisi assumenda assumenda molestiae architecto magnam in architecto officia recusandae commodi voluptas quas velit aut expedita voluptas molestias accusantium ad excepturi quisquam ad nihil exercitationem iure cum dignissimos voluptatum rerum impedit.", "Generic Cotton Bike" },
                    { new Guid("ae711719-dc63-40ab-b496-e27a5303f081"), "Itaque non alias nostrum magnam maiores vitae eveniet dicta quasi ut eum consequatur occaecati fugit ratione nulla earum sed delectus nemo totam vero omnis qui enim quam provident id debitis ea nulla repellendus nemo non repellendus sint ut reiciendis voluptas cumque quis culpa error assumenda quisquam totam officia atque blanditiis.", "Sleek Fresh Chicken" },
                    { new Guid("b058f447-6faa-435c-9f14-7332e4839d86"), "Suscipit perferendis exercitationem perspiciatis omnis perspiciatis est velit et odit sint fugiat voluptas aspernatur perferendis neque rem ad quod sit necessitatibus ex porro quas nam culpa quidem et tempore velit non quo eveniet omnis ut ab cum iure quis facere sed facere cumque qui eligendi quam a nam corporis qui.", "Licensed Concrete Salad" },
                    { new Guid("b75c6d29-a747-44ed-b7f6-60268cf77fd4"), "Modi sed natus voluptatem aperiam ut quia dolore dolorem labore eligendi a natus veniam occaecati sit deleniti aperiam magni et sit voluptatum et eveniet corporis dolore et dolorum beatae nobis est sint rerum ullam dolor accusantium similique dignissimos nam sunt nam est eos quia rerum beatae est quod non quod.", "Handcrafted Fresh Pants" },
                    { new Guid("ba35633c-e66b-461d-9fdb-e3a53f14a912"), "Optio quae ipsam officia dignissimos perferendis ut voluptas ea inventore temporibus aut assumenda est dolorum et earum qui sapiente et velit in nihil et voluptatem ut necessitatibus provident nostrum numquam nam et nam sed placeat est eius eaque totam hic ut magnam perferendis cupiditate quia assumenda vel laborum nihil in.", "Practical Rubber Bacon" },
                    { new Guid("be60554f-6ab6-478a-bbaa-88c529171598"), "Architecto dolorem repellat rerum nobis voluptas nulla corrupti doloribus qui corrupti error voluptas provident temporibus in vero nostrum voluptatibus mollitia quae sequi nostrum est tempore quaerat modi sed esse et excepturi et accusamus occaecati ipsam sint enim fugit vel numquam laudantium ut voluptas rerum labore aliquid maxime excepturi distinctio ut.", "Sleek Soft Chair" },
                    { new Guid("c1652037-3609-41b5-86d4-b6c3d5438dd5"), "Porro quia est non sint temporibus magni architecto explicabo molestias rem itaque voluptatem ut voluptatem quae ducimus ex reiciendis quia dolor facilis ullam necessitatibus occaecati ut et sed beatae molestias corporis suscipit quis dolores aut sed enim eius possimus ipsam sequi est commodi recusandae laudantium ab temporibus veniam qui excepturi.", "Refined Fresh Cheese" },
                    { new Guid("c18e03f5-3bc4-4185-8c40-10ba8d6da2fc"), "Occaecati quos sed repellendus nobis dicta unde distinctio qui nam sed enim accusamus architecto cumque eum tempore debitis debitis qui enim eum molestiae quis cum eum vero laudantium sint in sapiente doloribus ipsum nostrum sed laudantium commodi omnis eius nesciunt recusandae reiciendis est velit labore quis ut at et et.", "Practical Rubber Sausages" },
                    { new Guid("c45f897b-cf03-4804-b6d6-62dd827b3a79"), "Sed natus labore voluptatum eos voluptatem saepe labore et voluptatem ipsam optio qui rerum perferendis omnis voluptatem impedit perspiciatis quia dolorum aut ad qui nemo sit non omnis et sed soluta unde minus eius vitae tempora beatae suscipit ipsa voluptatem alias rerum sunt numquam adipisci in deserunt harum rerum ex.", "Intelligent Plastic Bacon" },
                    { new Guid("c4d67725-13e9-4316-8d8b-8fb25f810878"), "Consequuntur ratione sunt distinctio doloribus voluptate sed perferendis odit aspernatur quam quo beatae ut quasi officiis cupiditate est enim sit sit aut et voluptates dolores quidem provident voluptas incidunt qui nemo consequatur eveniet ad ut sed facilis consequatur libero unde aut officia laudantium vel sit qui ut ipsa consequatur non.", "Awesome Wooden Car" },
                    { new Guid("c59702ae-52c3-4369-b5b4-ea70395b394c"), "Voluptatibus et ducimus voluptas voluptate excepturi sit asperiores illum quo sint illo enim rerum cum repellendus necessitatibus illum molestiae nihil porro non autem laudantium pariatur vitae neque dolore harum totam dolorem debitis mollitia enim ullam tempore sint culpa repellendus maiores placeat perspiciatis voluptatum voluptatem dolor ut aut dolorem deserunt ab.", "Rustic Steel Chips" },
                    { new Guid("cbde9807-9292-48f6-ad2d-26eaa3c74ee5"), "Et est a nobis quaerat autem dolore distinctio eligendi ut maiores sunt fugiat soluta laudantium recusandae sed est aut voluptatem nemo ad quos numquam esse aut suscipit voluptatem qui maiores sint ducimus atque iusto unde ab et animi qui ea ut sequi rerum deleniti assumenda ratione quisquam inventore quia tempora.", "Handmade Frozen Computer" },
                    { new Guid("ccfc2014-62f2-48e0-8742-22a9912b2dbc"), "Doloremque officia optio at quo cum expedita sit consequatur ut velit voluptatem nihil beatae corporis temporibus ea necessitatibus voluptas aut id et magni consequuntur voluptatem sit neque ipsa consequuntur pariatur nisi maxime illum quae libero tenetur non ipsum et ex perferendis et voluptate vitae autem quidem eaque sint qui odit.", "Generic Frozen Towels" },
                    { new Guid("cf4321a7-e4b1-44bb-803c-ae8cb1b18491"), "Cumque animi nihil ut vero voluptatem ut est aliquid rerum voluptate sed ut laudantium saepe qui optio ducimus repellendus rem aut vel eum praesentium fugit dolores sit nulla non id pariatur rem porro autem voluptas fuga voluptatem sequi ea unde debitis nemo tempore in maiores voluptates veniam sunt voluptatem voluptas.", "Tasty Fresh Bike" },
                    { new Guid("cf9893b6-5cdc-44f6-8865-17fde0993456"), "Beatae nisi sunt deleniti quas molestiae voluptatibus harum quos ipsum facilis molestiae officiis quia quos doloremque ut iusto ratione ipsum quo ipsa vero aut iure vel illum quidem et natus rerum itaque est nostrum atque soluta rerum error voluptate ea magni similique id pariatur corporis ipsam eius consequatur explicabo ipsa.", "Ergonomic Metal Towels" },
                    { new Guid("d28a78cf-4dbe-4e93-9497-c6d1c0688104"), "Qui vel iure ab consequatur id neque minima possimus et cum et officia illum autem et et temporibus voluptate aut corrupti dicta ut officiis voluptatem delectus et sit ut magni sit excepturi rem natus omnis dicta incidunt enim similique officia est repellat dignissimos facere quia iste est tempora dolor ipsa.", "Incredible Granite Pants" },
                    { new Guid("d3d947f1-8de7-4f57-b3ff-02a40b6ec994"), "Aut itaque sit totam numquam maxime minus nihil vitae qui odit sed et odit neque occaecati ipsa deleniti dolores rerum dolorem ea sed sunt ea minima voluptatem rerum impedit asperiores officiis laudantium est quis ratione et sequi a rerum nobis quam autem est molestiae tempore molestiae nisi est laudantium dolores.", "Intelligent Metal Chair" },
                    { new Guid("d3f3bdbe-6b08-4a5f-8728-fbc6ab916e5e"), "Est odio provident atque veritatis facilis est reiciendis itaque qui in dolorem dolores placeat laborum commodi ut ex et at in eum expedita aut ab neque debitis sed quia quis est consequatur voluptas sunt delectus dolor quas et officia distinctio molestiae voluptatem debitis veritatis magnam nostrum repudiandae accusantium labore eos.", "Awesome Rubber Soap" },
                    { new Guid("d49fa1ef-ff8c-4874-931a-8f8d2ba0ca81"), "Accusantium repellendus est dignissimos dicta sunt suscipit aut mollitia temporibus error eveniet excepturi molestiae aperiam itaque illum perspiciatis rerum suscipit fuga placeat atque voluptas et nam ad debitis rerum voluptas sed aut vel sed doloribus ullam odio quas autem nemo iure asperiores sit numquam ad sunt voluptatem velit aliquam eos.", "Awesome Rubber Gloves" },
                    { new Guid("da114030-0412-4fc8-98b6-ba454bba246a"), "Excepturi laborum illum sunt excepturi odio repellendus aliquid rerum reiciendis odio est aliquam accusamus doloribus animi dolorem ullam error dolorum et ea quod quas magnam omnis eum nihil esse laborum veritatis suscipit velit dolorum earum iure sapiente iste nesciunt est dolores et neque vel quisquam et rerum eos quia quas.", "Handcrafted Rubber Bike" },
                    { new Guid("da673f8e-73d1-4398-9238-be7ec4bac7a1"), "Et impedit quis similique officiis expedita assumenda accusantium aspernatur suscipit quidem illum dolores quae eos in nostrum eius fugiat iure accusantium ut quae fuga illum modi alias rerum fuga voluptatibus ducimus aut vel maiores dicta quam reprehenderit et ut aut ut perferendis provident officiis eveniet iusto repellat ut magni fugit.", "Tasty Fresh Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "MoTa", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("da8b5f86-9cfb-4b53-98a7-42191977be76"), "Voluptas amet dolorem sed beatae cum quibusdam iure et sequi eius ut sequi et temporibus ipsam cupiditate ducimus officiis rem aut eveniet reiciendis eveniet rem animi ut ut quos voluptatibus nulla eius magni rerum quam soluta repudiandae veniam quis quia dolor nisi est inventore magni quidem enim omnis fugiat dolores.", "Handcrafted Rubber Salad" },
                    { new Guid("dfa8e45f-31fb-48e9-a2eb-102a131a12e5"), "Error et molestiae reprehenderit ullam et rem sit consequatur voluptas neque ullam quibusdam provident sed a ex deserunt quia sint corporis dolorem et aut voluptas velit ut sint soluta dolorem qui sunt qui et ut ut qui aut omnis et fugiat sed dicta ut nemo libero modi voluptas rem placeat.", "Generic Frozen Pizza" },
                    { new Guid("e0f1d0f4-29c8-47be-b31c-bfb46ff16e53"), "Necessitatibus tenetur voluptatum saepe modi nobis omnis occaecati inventore et dolorem rem dolorum quidem vel qui repudiandae sequi similique eveniet veritatis est similique doloremque ipsum consequatur odio dolorem voluptas magni esse maxime tempore et eligendi nihil consequatur itaque quis aut voluptatibus earum ab veniam quia ut quia distinctio enim consectetur.", "Unbranded Steel Sausages" },
                    { new Guid("e2d89b20-ce99-4d3d-8e9a-bd7a142b2015"), "Recusandae qui tenetur facilis aut ea dignissimos veniam nihil et sunt non illo aut expedita ipsam dolores molestias ad maxime dolorem adipisci hic quas dolores officia explicabo aliquid sit inventore facere et omnis veniam consectetur repellat necessitatibus maxime aut et consequatur id consequatur id est omnis perspiciatis optio commodi a.", "Ergonomic Fresh Soap" },
                    { new Guid("e33b9383-2f07-47b9-8df9-79377f2792f3"), "Nulla repudiandae harum incidunt labore dignissimos repellendus quisquam ratione iste sint alias et consequatur qui sed harum voluptate explicabo minima deserunt dolore et aspernatur laudantium et sunt consequatur soluta soluta doloribus et quo quod officiis qui accusantium officiis voluptatem est est sequi dolor doloribus consequatur qui ut enim quae impedit.", "Practical Soft Tuna" },
                    { new Guid("e569deb0-a1df-47f3-8e93-d6ae31b39e1d"), "Fugit ipsum sed dicta et cumque maiores accusamus voluptatem odio aut dolor delectus inventore eum consequuntur iure explicabo aliquam beatae architecto quibusdam quia hic quod quo qui sit explicabo aperiam fuga doloribus sed expedita nesciunt incidunt vero consectetur aperiam repellat veritatis velit vel a exercitationem sapiente reprehenderit sit qui aut.", "Practical Cotton Table" },
                    { new Guid("ebd732f5-12d8-43ac-bdf4-3d78ad060c7e"), "Qui officiis dolor et quia quo quia nulla illum consequatur sunt optio rerum quo veniam neque est vel ut est cupiditate neque corrupti occaecati animi est et quasi cupiditate modi ut voluptas voluptas cupiditate doloremque nesciunt libero est et ad et cupiditate officia et voluptates non ut nisi eaque natus.", "Intelligent Plastic Keyboard" },
                    { new Guid("eed8d746-67dd-4c6e-8b34-51c5f9810b0d"), "Similique quo sint illum delectus ad eveniet qui natus est sed voluptates voluptas assumenda eius et nam vel molestias iste et libero qui libero ducimus commodi nulla autem nesciunt voluptatem voluptas ea aperiam dolorum a dolorem est repudiandae quas officiis velit nemo rerum quibusdam placeat mollitia voluptas quaerat earum qui.", "Gorgeous Granite Mouse" },
                    { new Guid("f015bffd-6a83-49d0-89c4-bce7f210e48b"), "Id commodi et quis quia non est natus sunt sit debitis labore ut enim nihil officia quae et nemo necessitatibus minus tenetur dignissimos porro incidunt consequatur quo ipsam fuga cumque alias sed eos illum libero aut autem autem praesentium ipsam aut est mollitia sint maxime qui molestiae numquam et odio.", "Intelligent Cotton Table" },
                    { new Guid("f042021d-4599-41d1-8943-c4c9438302e6"), "Numquam perferendis fugit eligendi ratione officia et quam est dolores quidem voluptatum ea quis dolorum asperiores doloremque molestiae enim unde saepe culpa unde sit sapiente unde est debitis hic eos numquam laborum qui similique et id corporis expedita sunt consequuntur possimus doloremque illo amet animi rem consectetur fugit et assumenda.", "Awesome Metal Chicken" },
                    { new Guid("f1c1ea56-d7a8-47a5-acb7-5c5a772cd7ca"), "Officiis ut maiores voluptatem aliquid enim eos dolores placeat dolorem aspernatur nesciunt blanditiis in voluptas aut minima optio maiores voluptas non velit quo eos vel id sapiente id ratione non aut rem aut facilis sequi veniam accusantium non omnis et blanditiis odio quia commodi possimus commodi quo aut harum sit.", "Unbranded Steel Chair" },
                    { new Guid("f808ac4e-d03b-472f-b44e-9013060e2fae"), "Nobis quia hic officiis cum quis accusantium officiis dolor odit dolores cumque modi earum quaerat aliquid et quod rerum accusamus harum culpa deleniti quas error autem quae suscipit necessitatibus voluptatibus voluptas et facilis sunt tempore est maxime odit nisi rerum alias magni non ea ea libero nisi temporibus voluptas dignissimos.", "Rustic Soft Shoes" },
                    { new Guid("fb225788-dc0b-4801-82c6-8051ff03ee91"), "Aut mollitia nisi dolorem dolorem veritatis omnis porro molestiae omnis ad amet voluptatem est a harum est est doloremque repellat temporibus voluptate iusto dolor vel magni est beatae voluptatem aliquid reprehenderit consequuntur pariatur tenetur eligendi vel est error recusandae quas ut dolor natus ut est asperiores cumque aut modi sit.", "Incredible Fresh Bike" },
                    { new Guid("fbdef37d-7fc1-4d04-96e2-441d86f7229e"), "Eligendi ut ut doloribus sit consequatur est aliquam corporis dolorum ut hic sequi voluptatibus qui at accusamus quia suscipit hic sunt error recusandae quisquam ea et nemo eum illo labore laborum corporis qui voluptate consequuntur occaecati quia iusto in et iure vitae qui dicta commodi qui perspiciatis tempore sapiente dicta.", "Fantastic Metal Soap" },
                    { new Guid("fc642a7b-ce00-46f8-a293-6dbdabc193c7"), "Ut et corrupti magnam ab sed odio et dolorum quis at quia possimus sit sit id temporibus excepturi quae et aperiam repellat ut est quod ex quia esse consequatur blanditiis facere fugit iusto sit saepe placeat ut omnis fugiat consequuntur illo totam rerum doloribus voluptas dolorem consequatur est consequatur facilis.", "Generic Concrete Shoes" },
                    { new Guid("fddfc934-1ae3-467c-9252-6f064fdd2abd"), "Numquam nisi eligendi placeat quia exercitationem temporibus velit porro et eum eaque vel quis ut vitae dolorem dolor tenetur quaerat dolores vitae soluta voluptatem aliquid porro nam voluptas vero deserunt voluptate rerum voluptas voluptatem odio necessitatibus sed quia est eos qui asperiores et ad nemo quae neque quibusdam omnis id.", "Refined Fresh Pizza" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("00ceaf09-8ec1-48ed-b5fa-faa455db91e9"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("0161fb24-8326-41e9-9384-b3a063aca590"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("05a8d55c-80b5-4a55-9657-8aafe0a75f7d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("05dc8c6d-8714-4e88-8e71-f595b546a97d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("08b66182-7878-4c3b-a0b2-753ca2263005"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("107643d6-d5c5-4d08-b138-af94748f0374"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("11343ca8-4b59-4143-8715-158c8d1e0645"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("13bb8a76-4ff4-4367-aaa2-6c9b96f86099"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("13f51973-cfa6-4b96-ac15-5ebe45589331"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("16f4e721-08fb-48ab-a27f-0eea1d432788"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("1c6f83f3-31ea-4e63-85a3-585f16e1dce0"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("204dd7a6-6711-47bd-b517-432f92591055"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2846d773-e529-4703-b462-891edf54d380"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("298c3997-435a-4c96-bc9f-39158f41d101"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2cd0da05-5aa9-43b3-b93d-07f7c21502cf"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2ed5c08c-f28c-4554-91df-add9ad0d85ba"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("2fbfbc22-2747-4b94-9b9f-603961a7670a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("37f664d4-40e4-41c0-82f5-38ff18bd94d5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("394558b4-a606-46ad-85c6-4ff1ee117a1b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3be5b71d-8e75-4c53-a657-d44746271499"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3c3603bc-9c03-4754-ae61-81d2d985d0c6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("3e5444be-0de0-4365-a70c-777b2ae97cc5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("419ff539-41a3-49ee-bc2f-e98469498727"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("42f118ae-930b-41f8-bedb-c0bcec853c19"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4a129f2a-7559-4cbd-bae8-0b398094a2f4"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4a999f1a-b206-41be-b4b2-23d00ab866f7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4c078e9e-8a68-4243-8f84-918a1faa622b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4d0dfdf1-1f9e-4fd6-8d5d-05106ca55e6c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4f8432d9-a3ec-4e75-9e9e-39dc3f84d8ea"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("4fefaa17-1fe8-4920-b985-7af44cb65d91"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("504f22d6-87fc-492c-910b-c3f5a041fa63"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5523209a-2472-4558-80ae-a3e4328bbb68"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("584eb7df-27df-47f4-820d-7a74a35625bc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5c971414-db4f-4d6f-9b7b-7566efe0d849"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5c9e963b-0527-4932-96a2-7ae92dc2295c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("5d54dc05-01e4-4bb0-b753-cae71df3e254"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6a824102-c9ee-4284-9bfc-430b3c2f4460"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6aca9bf0-9678-45aa-bcc7-bec555356656"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("6d63e96e-84f3-40a1-b954-7c71a4e923d1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("75fdae46-59f5-459f-9ddf-6880f05c0228"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("76f70682-ca8f-45c2-80ac-24555f08eab5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7a9e529b-15f6-4cb0-a106-c7d2ab09e962"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("7deb7d53-8832-4413-b5d3-0115940bf14d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("80e9591d-ce73-4ae3-b9e2-916cce7b370a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("82373d86-a9a2-431b-823a-ac91011ebdda"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("82e2ccd0-c1ab-4d51-ad7b-b1a4c44263c3"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("845dd74e-2f0b-416b-8337-3da61a299ff6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("84d70e4b-f593-48f9-b3a7-2532a4735739"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8bdc645a-cbb1-4cf3-a2d7-d18359ae6b30"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8c2d7c57-3637-4801-8f7a-aff5cf27abe2"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("8e6fc044-525d-406a-9ffe-e36522b8ac22"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("926bc23b-0d64-4f65-9662-8c221adf8709"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("996ae7f7-0dbe-4e8e-894c-16ca6d5f2066"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a0d7ce1d-f6a0-4549-bf66-6c68a10ad345"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a29810b3-86fa-4efc-8bdc-8c16c2df4c44"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a554a621-4de3-46df-9a05-29cecc484b4f"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a5a72697-7641-4863-a6e3-dcc86176c0ab"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a61c7f37-d13f-4947-9d33-124a56391ca6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a6dd5f1b-4f15-462e-b07c-4b9b75fe9803"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("a80b248d-80f7-48f8-90f9-6c59b6693094"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("aaf4ed9d-140c-462a-bcfc-da223f2d365e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("aafe8bd6-4c77-47ac-9b82-8859c988f54d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("abb0f9b9-7616-409c-8f8f-f17d3d078268"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ad83ba3e-8a6f-402f-8c10-2618b59b5855"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ae711719-dc63-40ab-b496-e27a5303f081"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b058f447-6faa-435c-9f14-7332e4839d86"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("b75c6d29-a747-44ed-b7f6-60268cf77fd4"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ba35633c-e66b-461d-9fdb-e3a53f14a912"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("be60554f-6ab6-478a-bbaa-88c529171598"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c1652037-3609-41b5-86d4-b6c3d5438dd5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c18e03f5-3bc4-4185-8c40-10ba8d6da2fc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c45f897b-cf03-4804-b6d6-62dd827b3a79"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c4d67725-13e9-4316-8d8b-8fb25f810878"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("c59702ae-52c3-4369-b5b4-ea70395b394c"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cbde9807-9292-48f6-ad2d-26eaa3c74ee5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ccfc2014-62f2-48e0-8742-22a9912b2dbc"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cf4321a7-e4b1-44bb-803c-ae8cb1b18491"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("cf9893b6-5cdc-44f6-8865-17fde0993456"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d28a78cf-4dbe-4e93-9497-c6d1c0688104"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d3d947f1-8de7-4f57-b3ff-02a40b6ec994"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d3f3bdbe-6b08-4a5f-8728-fbc6ab916e5e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("d49fa1ef-ff8c-4874-931a-8f8d2ba0ca81"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("da114030-0412-4fc8-98b6-ba454bba246a"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("da673f8e-73d1-4398-9238-be7ec4bac7a1"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("da8b5f86-9cfb-4b53-98a7-42191977be76"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("dfa8e45f-31fb-48e9-a2eb-102a131a12e5"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e0f1d0f4-29c8-47be-b31c-bfb46ff16e53"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e2d89b20-ce99-4d3d-8e9a-bd7a142b2015"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e33b9383-2f07-47b9-8df9-79377f2792f3"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("e569deb0-a1df-47f3-8e93-d6ae31b39e1d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("ebd732f5-12d8-43ac-bdf4-3d78ad060c7e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("eed8d746-67dd-4c6e-8b34-51c5f9810b0d"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f015bffd-6a83-49d0-89c4-bce7f210e48b"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f042021d-4599-41d1-8943-c4c9438302e6"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f1c1ea56-d7a8-47a5-acb7-5c5a772cd7ca"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("f808ac4e-d03b-472f-b44e-9013060e2fae"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fb225788-dc0b-4801-82c6-8051ff03ee91"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fbdef37d-7fc1-4d04-96e2-441d86f7229e"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fc642a7b-ce00-46f8-a293-6dbdabc193c7"));

            migrationBuilder.DeleteData(
                table: "SanPhams",
                keyColumn: "Id",
                keyValue: new Guid("fddfc934-1ae3-467c-9252-6f064fdd2abd"));

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "MoTa", "TenSanPham" },
                values: new object[,]
                {
                    { new Guid("11772746-d676-4046-8f16-d51d420afe98"), "SP3", "San pham 3" },
                    { new Guid("4b23fa81-784b-4b03-be59-4285b9b2d949"), "SP2", "San pham 2" },
                    { new Guid("4c73d08d-2157-4b8d-b4f9-d52528e3c8d6"), "SP4", "San pham 4" },
                    { new Guid("65197395-6baf-463b-8952-862efc23d831"), "SP1", "San pham 1" }
                });
        }
    }
}
