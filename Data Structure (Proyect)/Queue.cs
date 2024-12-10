using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure__Proyect_
{
    internal class Queue
    {
        public Node head; // Primer elemento (frente de la cola)

        public Queue()
        {
            head = null;
        }

        public void Enqueue(Node newNode)
        {

            if (IsEmpty())
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            return;
        }


        public Node Dequeue()
        {
            if (!IsEmpty())
            {
                Node dequeuedNode = head;
                head = head.Next;
                dequeuedNode.Next = null; // Desconectar el nodo desencolado
                return dequeuedNode;
            }
            return null; // Si la cola está vacía
        }


        // Obtener el nodo en el frente sin desencolarlo
        public Node Peek()
        {
            if (!IsEmpty())
            {
                return head;
            }
            return null; // Si la cola está vacía
        }



        public bool IsEmpty()
        {
            return head == null;

        }

        public int Size()
        {
            int count = 0;
            Node current = head;

            // Recorre la cola desde el frente hasta el final
            while (current != null)
            {
                count++;
                current = current.Next; // Avanza al siguiente nodo
            }

            return count; // Devuelve el número total de elementos Size: gets the number of objects in the queue 

        }

    }

    
    internal class CircularQueue
    {
        private Node front;
        private Node rear;
        private int size;

        public CircularQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        // Verificar si la cola está vacía
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Agregar un elemento a la cola
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);

            // Si la cola está vacía, el nuevo nodo será el primero y el último
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
                rear.Next = front; // El último nodo apunta al primero
            }
            else
            {
                rear.Next = newNode;  // El nodo anterior apunta al nuevo
                rear = newNode;       // El último nodo es ahora el nuevo nodo
                rear.Next = front;    // El último nodo apunta de nuevo al primer nodo
            }
            size++;
        }

        // Eliminar un elemento de la cola
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            int value = front.Value;

            if (front == rear)  // Si solo hay un nodo
            {
                front = null;
                rear = null;
            }
            else
            {
                front = front.Next; // El primer nodo se mueve al siguiente nodo
                rear.Next = front;  // El último nodo apunta al nuevo primer nodo
            }

            size--;
            return value;
        }

        // Ver el primer elemento de la cola sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía");
            }
            return front.Value;
        }

        // Obtener el tamaño de la cola
        public int Size()
        {
            return size;
        }
    }








    //static
    internal class QueueStatic : IEnumerable
    {
        int head;
        int count;
        int size;
        public int?[] data_number;


        public QueueStatic(int size)
        {
            head = 0;
            count = 0;
            data_number = new int?[size];
        }


        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == data_number.Length;
        }

        public void Enqueue(int Number)
        {
            if (!IsFull())
            {
                data_number[count] = Number;
                count++;
                return;
            }

            return;

        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInHead = data_number[0].ToString();

            // Desplazar los elementos restantes hacia la izquierda
            for (int i = 0; i < count - 1;)
            {
                data_number[i] = data_number[i + 1];
                i++;
            }

            count--;
            data_number[count] = null;

            return numberInHead;
        }

        public int Size()
        {

            return count;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInTheHead = data_number[0].ToString();
            return numberInTheHead;
        }
        // Implementa el método GetEnumerator para la interfaz IEnumerable
        public IEnumerator GetEnumerator()
        {
            int i = head;
            int elementsReturned = 0;

            while (elementsReturned < count)
            {
                yield return data_number[i];
                i = (i + 1) % data_number.Length;  // Avanzar circularmente
                elementsReturned++;
            }
        }


    }



    internal class CircularQueueStatic
    {
        private int[] queue;  // Arreglo que almacena los elementos de la cola
        private int front;    // Índice del frente de la cola
        private int rear;     // Índice del final de la cola
        private int size;     // Número actual de elementos en la cola
        private int capacity; // Capacidad máxima de la cola

        public CircularQueueStatic(int capacity)
        {
            this.capacity = capacity;
            queue = new int[capacity];  // Inicializa el arreglo con la capacidad dada
            front = -1;
            rear = -1;
            size = 0;
        }

        // Verifica si la cola está vacía
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Verifica si la cola está llena
        public bool IsFull()
        {
            return size == capacity;
        }

        // Agrega un elemento al final de la cola
        public void Enqueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("La cola está llena, no se puede agregar el elemento.");
                return;
            }

            if (front == -1)  // Si la cola está vacía, coloca el primer elemento
            {
                front = 0;
            }

            rear = (rear + 1) % capacity;  // Avanza al siguiente índice circularmente
            queue[rear] = value;           // Agrega el valor al final de la cola
            size++;
        }

        // Elimina y devuelve el elemento del frente de la cola
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            int value = queue[front];
            if (front == rear)  // Si solo hay un elemento, la cola queda vacía
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front = (front + 1) % capacity;  // Avanza al siguiente índice circularmente
            }
            size--;
            return value;
        }

        // Ver el primer elemento sin eliminarlo
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            return queue[front];
        }

        // Imprimir todos los elementos de la cola
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            int i = front;
            do
            {
                Console.Write(queue[i] + " ");
                i = (i + 1) % capacity;
            } while (i != (rear + 1) % capacity);
            Console.WriteLine();
        }

        // Obtener el tamaño actual de la cola
        public int Size()
        {
            return size;
        }
    }



    class PriorityQueueVectorOfVectors
    {
        private int[][] queues;

        public PriorityQueueVectorOfVectors(int numPriorities, int maxSize)
        {
            queues = new int[numPriorities][];
            for (int i = 0; i < numPriorities; i++)
            {
                queues[i] = new int[maxSize];
            }
        }

        public void Enqueue(int item, int priority, ref int[] sizes)
        {
            if (priority >= 0 && priority < queues.Length)
            {
                queues[priority][sizes[priority]] = item;
                sizes[priority]++;
            }
            else
            {
                Console.WriteLine("Invalid priority.");
            }
        }

        public int Dequeue(ref int[] sizes)
        {
            for (int i = queues.Length - 1; i >= 0; i--)
            {
                if (sizes[i] > 0)
                {
                    int item = queues[i][0];
                    // Shift elements to the left
                    for (int j = 0; j < sizes[i] - 1; j++)
                    {
                        queues[i][j] = queues[i][j + 1];
                    }
                    sizes[i]--;
                    return item;
                }
            }
            throw new InvalidOperationException("Queue is empty.");
        }

        public bool IsEmpty(int[] sizes)
        {
            foreach (var size in sizes)
            {
                if (size > 0)
                    return false;
            }
            return true;
        }
    }

    class PriorityQueueVectorOfLists
    {
        private List<int>[] queues;

        public PriorityQueueVectorOfLists(int numPriorities)
        {
            queues = new List<int>[numPriorities];
            for (int i = 0; i < numPriorities; i++)
            {
                queues[i] = new List<int>();
            }
        }

        public void Enqueue(int item, int priority)
        {
            if (priority >= 0 && priority < queues.Length)
            {
                queues[priority].Add(item);
            }
            else
            {
                Console.WriteLine("Invalid priority.");
            }
        }

        public int Dequeue()
        {
            for (int i = queues.Length - 1; i >= 0; i--)
            {
                if (queues[i].Count > 0)
                {
                    int item = queues[i][0];
                    queues[i].RemoveAt(0);
                    return item;
                }
            }
            throw new InvalidOperationException("Queue is empty.");
        }

        public bool IsEmpty()
        {
            foreach (var queue in queues)
            {
                if (queue.Count > 0)
                    return false;
            }
            return true;
        }
    }
    class PriorityQueueListOfVectors
    {
        private List<List<int>> queues;

        public PriorityQueueListOfVectors(int numPriorities)
        {
            queues = new List<List<int>>(numPriorities);
            for (int i = 0; i < numPriorities; i++)
            {
                queues.Add(new List<int>());
            }
        }

        public void Enqueue(int item, int priority)
        {
            if (priority >= 0 && priority < queues.Count)
            {
                queues[priority].Add(item);
            }
            else
            {
                Console.WriteLine("Invalid priority.");
            }
        }

        public int Dequeue()
        {
            for (int i = queues.Count - 1; i >= 0; i--)
            {
                if (queues[i].Count > 0)
                {
                    int item = queues[i][0];
                    queues[i].RemoveAt(0);
                    return item;
                }
            }
            throw new InvalidOperationException("Queue is empty.");
        }

        public bool IsEmpty()
        {
            foreach (var queue in queues)
            {
                if (queue.Count > 0)
                    return false;
            }
            return true;
        }
    }
    class PriorityQueueListOfLists
    {
        private List<List<int>> queues;

        public PriorityQueueListOfLists(int numPriorities)
        {
            queues = new List<List<int>>(numPriorities);
            for (int i = 0; i < numPriorities; i++)
            {
                queues.Add(new List<int>());
            }
        }

        public void Enqueue(int item, int priority)
        {
            if (priority >= 0 && priority < queues.Count)
            {
                queues[priority].Add(item);
            }
            else
            {
                Console.WriteLine("Invalid priority.");
            }
        }

        public int Dequeue()
        {
            for (int i = queues.Count - 1; i >= 0; i--)
            {
                if (queues[i].Count > 0)
                {
                    int item = queues[i][0];
                    queues[i].RemoveAt(0);
                    return item;
                }
            }
            throw new InvalidOperationException("Queue is empty.");
        }

        public bool IsEmpty()
        {
            foreach (var queue in queues)
            {
                if (queue.Count > 0)
                    return false;
            }
            return true;
        }
    }
}
