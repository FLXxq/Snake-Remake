using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelGrid
{

    private Vector2Int foodGridPosition;
    private GameObject foodGameObject;
    private int width;
    private int height;
    private Snake snake;
    


    private void Start()
    {
        
    }

    public LevelGrid(int width, int height) {
        this.width = width;
        this.height = height;
    }

    public void Setup(Snake snake) {
        this.snake = snake;

        SpawnFood();
    }

    private void SpawnFood() {
        int w, h;   
        while (true)
        {
            w = Random.Range(2, width);
            h = Random.Range(2, height);
            if ((w==14 & h==26) || (w == 26 & h == 26) || (w == 26 & h == 14) || (w == 14 & h == 14) || (w == 20 & h == 26) || (w == 26 & h == 20) || (w == 20 & h == 14) || (w == 14 & h == 20))
            {
                continue;
            }
            else
            {
                break;
            }
        }
        do {

            foodGridPosition = new Vector2Int(w, h);
            
        } while (snake.GetFullSnakeGridPositionList().IndexOf(foodGridPosition) != -1);

        foodGameObject = new GameObject("Food", typeof(SpriteRenderer));
        foodGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.i.foodSprite;
        foodGameObject.transform.position = new Vector3(foodGridPosition.x, foodGridPosition.y);
    }

    public bool TrySnakeEatFood(Vector2Int snakeGridPosition) {
        if (snakeGridPosition == foodGridPosition) {
            Object.Destroy(foodGameObject);
            SpawnFood();
            GameHandler.AddScore();
            
            return true;
        } else {
            return false;
        }
    }
    /*
    public Vector2Int ValidateGridPosition(Vector2Int gridPosition) {
        if (gridPosition.x < 0) {
            gridPosition.x = width - 1;
        }
        if (gridPosition.x > width - 1) {
            gridPosition.x = 0;
        }
        if (gridPosition.y < 0) {
            gridPosition.y = height - 1;
        }
        if (gridPosition.y > height - 1) {
            gridPosition.y = 0;
        }
        return gridPosition;
    }*/
  
}
