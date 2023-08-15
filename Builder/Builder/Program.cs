using Builder.Builders;
using Builder.Items;

MenuItemBuilder MenuItemBuilder = new MenuItemBuilder();
MenuItemBuilder.Build();
Order order = new Order();
order.Add(MenuItemBuilder.GetMenuItem());
MenuItemBuilder.Reset();
MenuItemBuilder.Build();
MenuItemBuilder.BuildDescription("descrição adicionada");
MenuItemBuilder.BuildCategory('A');
order.Add(MenuItemBuilder.GetMenuItem());
order.ListParts();


