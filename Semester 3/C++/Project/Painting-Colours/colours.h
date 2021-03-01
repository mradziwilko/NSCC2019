#pragma once

#include <QWidget>

class Colours : public QWidget {

  public:
    Colours(QWidget *parent = 0);

  protected:
    void paintEvent(QPaintEvent *e);

  private:
    void doPainting();
};
