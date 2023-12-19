using System;

namespace rpgBOGA
{

    class Program
    {


        static bool bedChecked = false;
        static bool boxChecked = false;
        static bool hasPick = false;
        static int itemsCollected = 0;
        static bool statueActivated = false;
        static bool doorOpened = false;
        static int triesToOpen = 0;
        static bool ventOpen = false;


        static void Main()
        {
            Console.WriteLine("Ты приходишь в себя и испуганно открываешь глаза. В голове мелькают образы, но твой разум еще слишком затуманен, чтобы составлять мысли, поэтому ты решаешь осмотреться. Вокруг тебя - просторная комната, освещенная лишь парой свечей.");
            Console.ReadLine();
            Console.WriteLine("Теперь, когда пламя свечей успоколило твое больное сознание, ты готов собраться с мыслями.");
            Console.WriteLine("Как звучит твое имя?");
            string name = Console.ReadLine();


            Console.WriteLine("Приятно познакомиться, " + name);
            Console.ReadLine();
            Console.WriteLine("Ты решаешь осмотреться и первое, за что хватается твой взгляд это: загадочная дверь, статуя, что находилась рядом, неаккуратно застеленная кровать, ящик, что стоял в углу, вентиляция и простая тумбочка. Что ты хочешь сделать? ");



            while (!doorOpened)
            {
                Console.WriteLine("Доступные действия: ");
                Console.WriteLine("1. Попробовать открыть дверь");
                Console.WriteLine("2. Заглянуть под кровать");
                Console.WriteLine("3. Открыть ящик, что стоит в углу комнаты");
                Console.WriteLine("4. Взглянуть на статую рядом с дверью");
                Console.WriteLine("5. Взглянуть на тумбочку");
                Console.WriteLine("6. Попытаться вскрыть вентиляцию");
                Console.WriteLine("Что ты сделаешь?");
                

                int choice = int.Parse(Console.ReadLine());





                switch (choice)
                {
                    case 1:
                        if (hasPick) 
                        {
                            Console.WriteLine("Ты достаешь отмычку, что нашел ранее. Руки леденеют от мысли о том, что у тебя лишь одна попытка.. Но ты настроен решительно. Спустя нескольк тяжелых мгновений ты ощущаешь, будто гора падает с твоих плеч, ведь дверь щелкает и со скрипом открывается..");
                            Console.ReadLine();
                            Console.WriteLine("В твое лицо ударяет яркий свет. Ты ощущаешь прохладный бриз на своем лице и твое выражение само собой сменяется на расслабленное.");
                            Console.ReadLine();
                            Console.WriteLine("Ты делаешь шаг вперед. Мысли в твоей голове все еще роятся. Как ты попал сюда? Зачем было это все?..");
                            Console.ReadLine();
                            Console.WriteLine("Но это все уже становится не так неважно. Теперь ты свободен. Теперь ты просыпаешься..");
                            doorOpened = true;
                        }
                        else if (!hasPick || !statueActivated)
                        {
                            Console.WriteLine("Замок.. Ты пробуешь дернуть ручку, просто на вскякий случай, но, как ты и ожидал, ничего не происходит");
                            Console.ReadLine();
                            Console.WriteLine("Может стоит поискать ключ? Или еще что-то, чем можно открыть дверь..");
                            Console.ReadLine();
                        }
                        else if (!hasPick || statueActivated)
                        {
                            Console.WriteLine("Теперь у тебя есть ключ и ты пробуешь открыть дверь с его помощью. Проходит пара неловких минут, прежде чем приходит осознание, что ключ здесь не подойдет. Придется искать другой способ.");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        if (!bedChecked)
                        {
                            Console.WriteLine("Ты заглядываешь под кровать. Из-за тусклого освещения тебе трудно различить, что там творится, а пыль, что скопилась там за все прошедшие годы щекочет твой нос, вынуждая отвлечься от твоего исследования на это неудобство.");
                            Console.ReadLine();
                            Console.WriteLine("Однако когда ты наконец можешь сконцентрироваться на своем деле, ты замечаешь некий предмет. Ты решаешься достать его.");
                            Console.WriteLine("Ты вытаскиваешь его к свету и отряхиваешь от вековой пыли. В твоих руках лежит нечто, напоминующее лапу кота, воссозданную из драгоценных камней и ценных металлов.");
                            Console.ReadLine();
                            Console.WriteLine("Похоже, что ты получил некий артефакт.");
                            bedChecked = true;
                            itemsCollected++;
                            CheckItemsAndActivateStatue();
                        }
                        else
                        {
                            Console.WriteLine("Ты вновь заглядываешь под кровать, но находишь лишь кучу пыли.");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        if (statueActivated)
                        {
                            Console.WriteLine("Ты подходишь к ящику и встаешь на колени, осматривая увесистый замок, что висит на нем. Осознание того, что у тебя есть ключ, который может подойти приходит быстро и ты с легкостью вскрываешь замок.");
                            Console.ReadLine();
                            Console.WriteLine("Удивительно, но несмотря на немалые габариты ящика, внутри можно найти лишь одну маленькую отмычку. Похоже, что попытка у тебя всего одна.");
                            hasPick = true;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ты смотришь на ящик, но кажется, что он не планирует открываться, каким бы строгим и угрожающим ни был твой взор.");
                            Console.ReadLine();
                        }
                        break;

                    case 6:
                       
                        {
                            if (triesToOpen == 2 && !ventOpen)
                            {
                                ventOpen = true;
                                Console.WriteLine("В твое лицо вылетает многолетняя пыль, отчего ты невольно закашлялся. Но твои старания окупаются, ибо вместе с этой пылью ты сумел достать маленький кошачий череп выполненный из алмазов, изумрудов и прочих прелестных камней. Поистине завораживающее зрелище.");
                                itemsCollected++;
                                CheckItemsAndActivateStatue();
                                

                            }
                            else if (triesToOpen < 2)
                            {
                                Console.WriteLine("Ты пробуешь дернуть вентиляцию и ощущаешь, как ослабели шурупы, что держат решетку. Возможно если ты попробуешь еще..");
                                triesToOpen++;
                                Console.ReadLine();
                            }
                            else if (ventOpen)
                            {
                                Console.WriteLine("Ты прверяешь вентиляцию вновь, но ничего не находишь.");
                                Console.ReadLine();
                            }

                        }
                        break;

                    case 5:
                        if (!boxChecked)
                        {
                            Console.WriteLine("Ты смотришь на тумбочку и замечаешь там нечто блестящее. Подбирая предмет в руки ты понимаешь, что это некая кошачья лапа, воссозданная с ювелирной точностью из разных ценных материалов.");
                            Console.ReadLine();
                            Console.WriteLine("Ты получаешь артефакт. Интересно, зачем он нужен?");
                            itemsCollected++;
                            boxChecked = true;
                            CheckItemsAndActivateStatue();
                        }
                        else
                        {
                            Console.WriteLine("Кажется, что нет смысла вновь проверять тумбочку, но ты все же бросаешь на нее свой взгляд. И оказываешься прав, ибо там действительно ничего нет. Печально.");
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        if (!statueActivated)
                        {
                            CheckItemsAndActivateStatue();
                        }
                        else if (statueActivated)
                        {
                            Console.WriteLine("Ты снова осматриваешь статую, а ее пустые глаза словно снова осматривают тебя. Кажется, что она больше не оживет, но чем больше ты в нее вглядываешься..");
                            Console.ReadLine();
                            Console.WriteLine("Пожалуй, будет лучше, если ты займешься чем-то еще.");
                            Console.ReadLine();
                        }

                        break;

                    default:
                        Console.WriteLine("Не совсем понятно, чего ты хочешь, попробуй еще раз.");
                        Console.ReadLine();
                        break;




                }


            }
        }


        static void CheckItemsAndActivateStatue()
        {
            if (itemsCollected == 3 && !statueActivated)
            {
                Console.WriteLine("Когда в твоих руках оказываются все три предмета, ты ощущаешь, как твои руки наливаются теплом. Ты поднимаеь взгляд и видишь, как внутри статуи словно что-то светится..");
                Console.ReadLine();
                Console.WriteLine("Ты подходишь к ней и снова смотришь на артефакты. Детальки в твоей голове складываются сами собой и ты вставляешь их в нужные слоты.");
                Console.ReadLine();
                Console.WriteLine("Статуя человекоподобного, но все еще непонтятного существа разжимает свои ладони и в них ты наблюдаешь ключ. Руки сами тянутся к нему.");
                Console.WriteLine("Теперь у тебя есть ключ!! От чего только он..");
                Console.ReadLine();
                statueActivated = true;
            }
            else if (itemsCollected < 3)
            {
                Console.WriteLine("Ты смотришь на статую, а если точнее, то на ее сердце, в котором зияет дыра. Словно чего-то не хватает..");
                Console.ReadLine();
            }
            
        }

    }
}

