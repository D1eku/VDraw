package app;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Point2D;

public class DrawArea extends JComponent implements MouseListener, MouseMotionListener {
    //Canvas panel to draw
    Canvas c;

    // Mouse coordinates
    private int currentX, currentY, oldX, oldY;

    // Activate Draws.
    private boolean isActivatedCircleDraw = false;
    private int clickCounterCircle = 0;
    Point2D center = null;
    Point2D p2;

    public DrawArea() {
        setDoubleBuffered(false);
        c = new Canvas();
        c.setSize(500,400);
        c.setBackground(Color.black);
        //c.addMouseListener(this);
        //c.addMouseMotionListener(this);
        c.setEnabled(true);
    }

    // now we create exposed methods
    public void clear() {
        this.c = new Canvas();
    }

    public void drawCircle() {
        isActivatedCircleDraw = true;
    }

    private void drawCircle(Point2D center, Point2D p2) {
        Graphics2D g = (Graphics2D) c.getGraphics();//Obten el graphics

        //Movemos el mouse para buscar el centro del circulo.
        //Hacemos click para seleccionar el centro.
        //Movemos el mouse para aumentar el radio del circulo.
        double radius = center.distance(p2);//Obten la distancia del centro al punto 2 que seria el radio
        System.out.println("El radio del circulo es: " + radius);//Printea radio
        System.out.println("El punto central del circulo es: " + center);//Printea el punto del centro.
        Ellipse2D circle = new Ellipse2D.Double(center.getX() - radius, center.getY() - radius, 2 * radius, 2 * radius);
        g.draw(circle);
        clickCounterCircle = 0;
        isActivatedCircleDraw = false;
    }

    @Override
    public void mouseClicked(MouseEvent e) {
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
        g.fillOval(currentX, currentY, 5, 5);
    }

    @Override
    public void mousePressed(MouseEvent e) {

    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }

    @Override
    public void mouseDragged(MouseEvent e) {
        Graphics g = c.getGraphics();//Obten el graphics
        // Obten las cordenadas actuales del mouse
        currentX = e.getX();
        currentY = e.getY();

        if (g != null) {
            // Guarda las coordenadas anteriores del mouse
            oldX = currentX;
            oldY = currentY;
        }

        g.fillOval(currentX, currentY, 5, 5);
    }

    @Override
    public void mouseMoved(MouseEvent e) {

    }
}
