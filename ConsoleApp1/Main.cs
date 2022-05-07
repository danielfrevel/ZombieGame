using ZombieGame;

Random randomizer = new Random();
var map = new Map();
var player = new Player(map);

int numberOfZombies = randomizer.Next(100);

for(int i = 0; i < numberOfZombies; i++)
{
    map.SpawnZombie(new Zombie());
}

