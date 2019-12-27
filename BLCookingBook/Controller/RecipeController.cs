using System;

public class RecipeController
{


	public RecipeController()
	{
	}

    public void AddIngridient()
    {
        //добавляем новый элемент в лист
        ingredients.Add(new Ingredient()
        {
            NameIngredient = tb_NameIngrid.Text,
            Сount = tb_CountIngrid.Text
        });
    }
}
