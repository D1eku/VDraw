package test;


// Java Program to create a to create a
// canvas and mouse listener to the
// canvas ( a circle of radius 5 will appear
// at the points where mouse are clicked or
//  dragged on the canvas)
import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Point2D;

class canvas extends JFrame implements MouseListener, MouseMotionListener {
    private int currentX, currentY, oldX, oldY;

    // Activate Draws to Circle.
    private boolean isActivatedCircleDraw = true;
    private int clickCounterCircle = 0;
    Point2D center = null;
    Point2D p2;

    // create a canvas
    Canvas c;

    // constuctor
    canvas()
    {
        super("canvas");

        JButton cButton = new JButton("()");


        // create a empty canvas
        c = new Canvas() {
            public void paint(Graphics g)
            {

            }
        };

        // set background
        c.setBackground(Color.black);

        // add mouse listener
        c.addMouseListener(this);
        c.addMouseMotionListener(this);

        add(cButton);
        add(c);
        setSize(800, 600);
        show();
    }

    // mouse listener  and mouse motion listener mehods
    public void mouseClicked(MouseEvent e)
    {
        Graphics g = c.getGraphics();

        g.setColor(Color.red);

        // get X and y position
        int x, y;
        x = e.getX();
        y = e.getY();

        // draw a Oval at the point
        // where mouse is moved
        //g.fillOval(x, y, 5, 5);
    }

    public void mouseMoved(MouseEvent e)
    {
    }

    public void mouseDragged(MouseEvent e)
    {
        Graphics g = c.getGraphics();//Obten el graphics
        // Obten las cordenadas actuales del mouse
        currentX = e.getX();
        currentY = e.getY();

        if (g != null) {
            // Guarda las coordenadas anteriores del mouse
            oldX = currentX;
            oldY = currentY;
        }

        //g.fillOval(currentX, currentY, 5, 5);
    }

    public void mouseExited(MouseEvent e)
    {
    }

    public void mouseEntered(MouseEvent e)
    {
    }

    public void mouseReleased(MouseEvent e)
    {

    }

    public void mousePressed(MouseEvent e)
    {
        oldX = e.getX();
        oldY = e.getY();
        Graphics g =  c.getGraphics();//Obten el graphics
        g.setColor(Color.red);//Cambia el color del graphics

        if(isActivatedCircleDraw){//Si se quiere dibujar un circulo
            clickCounterCircle++;//Aumenta en 1 la cantidad de clicks dentro del circulo

            if(clickCounterCircle == 1){//Si se presiono 1 vez el click
                //Obtienes el primer punto osea el centro
                center = new Point2D.Double(e.getX(), e.getY());
                System.out.println(center);
            }

            if(clickCounterCircle == 2){
                //Obtienes el segundo punto
                p2 = new Point2D.Double(e.getX(), e.getY());
                drawCircle(center, p2);//Dibuja el criculo.
            }
        }

        // draw a Oval at the point
        // where mouse is moved
        //g.fillOval(currentX, currentY, 5, 5);
    }

    public void drawCircle() {
        isActivatedCircleDraw = true;
    }

    private void drawCircle(Point2D center, Point2D p2) {
        Graphics2D g = (Graphics2D) c.getGraphics();//Obten el graphics
        g.setColor(Color.red);//Cambia el color del graphics
        //Movemos el mouse para buscar el centro del circulo.
        //Hacemos click para seleccionar el centro.
        //Movemos el mouse para aumentar el radio del circulo.
        double radius = center.distance(p2);//Obten la distancia del centro al punto 2 que seria el radio
        System.out.println("El radio del circulo es: " + radius);//Printea radio
        System.out.println("El punto central del circulo es: " + center);//Printea el punto del centro.
        Ellipse2D circle = new Ellipse2D.Double(center.getX() - radius, center.getY() - radius, 2 * radius, 2 * radius);
        g.draw(circle);
        clickCounterCircle = 0;
        //isActivatedCircleDraw = false;
    }

    // main class
    public static void main(String args[])
    {
        canvas c = new canvas();
    }
}
