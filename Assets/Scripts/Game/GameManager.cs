using Zenject;

// TODO rename 
// TODO - redundant ? 

public class GameManager : IInitializable
{

    private readonly IWindowController _windowController;
    private readonly ICharacterController _characterController;

    public GameManager(IWindowController windowController, ICharacterController characterController)
    {
        _windowController = windowController;
        _characterController = characterController;
    }

    public void Initialize()
    {
        StartGame();
    }

    private void StartGame()
    {
        _windowController.OpenWindow(EWindowType.Main);
        
        // set up character - by giving him items, maybe later 
    }
}
