using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_2
{
    public class BFS
    {
        public Queue<int> queue = new Queue<int>();

        public string search(Node node, int value)
        {
            int queueElement;
            if (node.Visited == false)
            {
                node.Visited = true;
                queue.Enqueue(node.Count);
                if (queue != null)
                {
                    queueElement = queue.Dequeue();
                    if (queueElement == value)
                    {
                        return("Элемент найден, его имя " + node.Name);
                    }
                    else
                        return search(node.Edges[0].Node,value);
                }
                else
                {
                    return ("Очередь пуста");
                }
            }
            else
                return ("Visited");
        }
    }
}
