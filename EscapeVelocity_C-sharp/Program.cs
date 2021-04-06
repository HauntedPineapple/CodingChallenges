using System;

namespace EscapeVelocity_C_sharp
{
    class Program
    {
        /// <summary>
        /// Gravitational Constant:
        /// G = 6.67e-11 Nm²/kg²
        /// </summary>
        const double G = 6.67e-11;

        /// The escape velocity equation is as follows:
        /// V -> escape velocity
        /// G -> gravitational constant
        /// m -> mass of planet
        /// r -> radius of planet
        /// V = sqrt(2Gm/r)

        static string EscapeVelocity(string planet)
        {
            string result = "\tThe escape velocity in m/s is: ";
            // mass and radius are in kg and m
            double mass = 5.976e24; // Earth's mass
            double radius = 637800; // Earth's equatorial radius

            switch (planet.ToLower())
            { //multiplies by the planet's value relative to Earth's
                case "mercury":
                    mass *= 0.0558;
                    radius *= 0.383;
                    break;
                case "venus":
                    mass *= 0.815;
                    radius *= 0.95;
                    break;
                case "earth":
                    break;
                case "mars":
                    mass *= 0.107;
                    radius *= 0.532;
                    break;
                case "jupiter":
                    mass *= 318;
                    radius *= 11.2;
                    break;
                case "saturn":
                    mass *= 95.1;
                    radius *= 9.41;
                    break;
                case "uranus":
                    mass *= 14.5;
                    radius *= 4.06;
                    break;
                case "neptune":
                    mass *= 17.2;
                    radius *= 3.88;
                    break;
                default:
                    return "ERROR: Invalid input!";
            }

            double escVel = 2 * G * mass;
            escVel = escVel / radius;
            escVel = Math.Sqrt(escVel);
            result += decimal.Round((decimal)escVel, 2);

            result += "\n\tThe escape velocity in km/h is : ";
            result += "\n\tThe escape velocity in km/s is : ";
            return result;
        }

        static string SystemEscapeVelocity(string planet)
        {
            string result = "";
            return "";
        }

        static void Main(string[] args)
        {
            string planet = "Earth";
            Console.WriteLine(EscapeVelocity(planet));

            Console.ReadLine();
        }
    }
}
