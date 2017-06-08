using System; // Using system so we can use Console.WriteLine later in this code. 

namespace TreehouseDefense {
    class Game {
        public static void Main() {
            Map map = new Map(8, 5);

            try //[6]
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                    }
                );

                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders) {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch (OutOfBoundsException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException) {
                Console.WriteLine("Unhandled TreeHouseDefenseException");
            }
            catch (Exception ex) {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}