using System;
using System.Drawing;
using System.IO;
using AForge.Imaging.Filters;

namespace PixelFilm
{
    class Filtros
    {
        //Filtros Generales
        public Bitmap filtroNegativo(Bitmap original)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            for(int x = 0; x < original.Height; x++)
            {
                for (int y = 0; y < original.Width; y++)
                {
                    oColor = original.GetPixel(y, x);

                    rColor = Color.FromArgb(oColor.A, 255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    resultado.SetPixel(y, x, rColor);
                }
            } 

            return resultado;
        }

        public Bitmap filtroEscalaGrises(Bitmap original)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            int pixel;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    pixel = (int)(oColor.R * 0.2126f + oColor.G * 0.7152f + oColor.B * 0.0722f);
                    //pixel = (oColor.R + oColor.G + oColor.B) / 3;

                    pixel = pixel > 255 ? 255 : pixel;

                    rColor = Color.FromArgb(oColor.A, pixel, pixel, pixel);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroCorreccionGamma(Bitmap original, float fr, float fg, float fb)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();


            //Crear tablas de color
            int[] rGamma = new int[256];
            int[] gGamma = new int[256];
            int[] bGamma = new int[256];

            for (int i = 0; i < 256; i++)
            {
                rGamma[i] = Math.Min(255, (int)((255.0f * Math.Pow(i / 255.0f, 1.0f / fr)) + 0.5f));
                gGamma[i] = Math.Min(255, (int)((255.0f * Math.Pow(i / 255.0f, 1.0f / fg)) + 0.5f));
                bGamma[i] = Math.Min(255, (int)((255.0f * Math.Pow(i / 255.0f, 1.0f / fb)) + 0.5f));
            }

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(oColor.A, rGamma[oColor.R], gGamma[oColor.G], bGamma[oColor.B]);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroBlurGaussiano(Bitmap original, int radio)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            double[,] kernel = CrearKernelGaussiano(radio);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    Color nuevoPixel = AplicarFiltroGaussiano(original, x, y, kernel, radio);

                    rColor = Color.FromArgb(oColor.A, nuevoPixel.R, nuevoPixel.G, nuevoPixel.B);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroBlurGaussiano2(Bitmap original, int radio)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            // Crear el filtro de desenfoque gaussiano
            GaussianBlur filtroGaussiano = new GaussianBlur(radio);


            resultado = filtroGaussiano.Apply(original);

            return resultado;
        }

        public Bitmap filtroEnfoqueLaplaciano(Bitmap original, int radio)
        {
            //radio min 9
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            // Crear el kernel laplaciano
            int[,] kernel = {
                    { -1, -1, -1 },
                    { -1,  radio, -1 },
                    { -1, -1, -1 }
                };

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    Color nuevoPixel = AplicarFiltroLaplaciano(original, x, y, kernel);

                    rColor = Color.FromArgb(oColor.A, nuevoPixel.R, nuevoPixel.G, nuevoPixel.B);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroBrillo(Bitmap original, float pBrillo)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            float tr, tg, tb;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    tr = oColor.R * pBrillo;
                    tg = oColor.G * pBrillo;
                    tb = oColor.B * pBrillo;

                    if (tr > 255) tr = 255;
                    else if (tr < 0) tr = 0;

                    if (tg > 255) tg = 255;
                    else if (tg < 0) tg = 0;

                    if (tb > 255) tb = 255;
                    else if (tb < 0) tb = 0;

                    rColor = Color.FromArgb(oColor.A, (int)tr, (int)tg, (int)tb);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroContraste(Bitmap original, float contraste)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            float tr, tg, tb;

            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    tr = ((((oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;
                    tg = ((((oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;
                    tb = ((((oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;

                    if (tr > 255) tr = 255;
                    else if (tr < 0) tr = 0;

                    if (tg > 255) tg = 255;
                    else if (tg < 0) tg = 0;

                    if (tb > 255) tb = 255;
                    else if (tb < 0) tb = 0;

                    rColor = Color.FromArgb(oColor.A, (int)tr, (int)tg, (int)tb);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroBrilloYContraste(Bitmap original, float pBrillo, float contraste)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            float tr, tg, tb;

            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    tr = oColor.R * pBrillo;
                    tg = oColor.G * pBrillo;
                    tb = oColor.B * pBrillo;

                    tr = ((((tr / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;
                    tg = ((((tg / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;
                    tb = ((((tb / 255.0f) - 0.5f) * c) + 0.5f) * 255.0f;

                    if (tr > 255) tr = 255;
                    else if (tr < 0) tr = 0;

                    if (tg > 255) tg = 255;
                    else if (tg < 0) tg = 0;

                    if (tb > 255) tb = 255;
                    else if (tb < 0) tb = 0;

                    rColor = Color.FromArgb(oColor.A, (int)tr, (int)tg, (int)tb);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroUmbral(Bitmap original, int umbral)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            //int umbral = 127;

            for (int x = 0; x < original.Height; x++)
            {
                for (int y = 0; y < original.Width; y++)
                {
                    oColor = original.GetPixel(y, x);

                    int valorBrillo = (int)(oColor.R * 0.3 + oColor.G * 0.59 + oColor.B * 0.11);

                    Color nuevoPixel = (valorBrillo > umbral) ? Color.White : Color.Black;

                    rColor = Color.FromArgb(oColor.A, nuevoPixel.R, nuevoPixel.G, nuevoPixel.B);

                    resultado.SetPixel(y, x, rColor);
                }
            }

            return resultado;
        }


        //Filtros para Foto
        public Bitmap filtroMosaico(Bitmap original, int mosaico)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            int sR, sG, sB;
            int R, G, B;

            int mosaicoX, mosaicoY, cuadro;


            for (int x = 0; x < original.Width; x += mosaico)
            {
                for (int y = 0; y < original.Height; y += mosaico)
                {
                    mosaicoX = mosaico;
                    mosaicoY = mosaico;
                    if(!(x <= original.Width - mosaico))
                    {
                        mosaicoX = original.Width - x;
                    }
                    if (!(y <= original.Height - mosaico))
                    {
                        mosaicoY = original.Height - y;
                    }

                    cuadro = mosaicoX * mosaicoY;

                    sR = 0; sG = 0; sB = 0;

                    for (int xm = x; xm < x + mosaicoX; xm++)
                    {
                        for (int ym = y; ym < y + mosaicoY; ym++)
                        {
                            oColor = original.GetPixel(xm, ym);

                            sR += oColor.R;
                            sG += oColor.G;
                            sB += oColor.B;
                        }
                    }

                    R = sR / cuadro;
                    G = sG / cuadro;
                    B = sB / cuadro;

                    oColor = original.GetPixel(x, y);
                    if (oColor.A == 0 && R == 0 && G == 0 && B == 0)
                    {
                        rColor = Color.FromArgb(oColor.A, R, G, B);
                    }
                    else
                    {
                        rColor = Color.FromArgb(R, G, B);
                    }
                    //rColor = Color.FromArgb(oColor.A, R, G, B);

                    for (int xm = x; xm < x + mosaicoX; xm++)
                    {
                        for (int ym = y; ym < y + mosaicoY; ym++)
                        {
                            resultado.SetPixel(xm, ym, rColor);
                        }
                    }
                }
            }

            return resultado;
        }

        public Bitmap filtroSepia(Bitmap original)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            float tr, tg, tb;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    tr = 0.393f * oColor.R + 0.769f * oColor.G + 0.189f * oColor.B;
                    tg = 0.349f * oColor.R + 0.686f * oColor.G + 0.168f * oColor.B;
                    tb = 0.272f * oColor.R + 0.534f * oColor.G + 0.131f * oColor.B;

                    tr = tr > 255 ? 255 : tr;
                    tg = tg > 255 ? 255 : tg;
                    tb = tb > 255 ? 255 : tb;

                    rColor = Color.FromArgb(oColor.A, (int)tr, (int)tg, (int)tb);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroReduccionRuido(Bitmap original, int tamañoVentana)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            //int tamañoVentana = 3; // Puedes ajustar este valor según tus necesidades

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    Color nuevoPixel = AplicarFiltroMediana(original, x, y, tamañoVentana);

                    rColor = Color.FromArgb(oColor.A, nuevoPixel.R, nuevoPixel.G, nuevoPixel.B);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroAberracionCromatica(Bitmap original, int aberracion)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            //int aberracion = 4;
            int r = 0, g = 0, b = 0;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    g = original.GetPixel(x, y).G;

                    if (x + aberracion < original.Width)
                    {
                        r = original.GetPixel(x + aberracion, y).R;
                    }
                    else
                    {
                        r = 0;
                    }

                    if (x - aberracion >= 0)
                    {
                        b = original.GetPixel(x - aberracion, y).B;
                    }
                    else
                    {
                        b = 0;
                    }

                    rColor = Color.FromArgb(oColor.A, r, g, b);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }


        //Filtros para Video

        public Bitmap filtroInterferenciaVHS1(Bitmap original, float posx)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            Random rnd = new Random();

            // Parámetros de efecto VHS
            int cantidadRuido = 0;
            int cantidadInterferencia = 50;
            //int aberrancia = 4;

            // Parámetros de deformación
            float amplitudX = 2.5f; // Amplitud en el eje X 
            int frecuenciaX = 30; // Frecuencia en el eje X

            int nuevoX;

            int r, g, b;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    nuevoX = x + (int)(amplitudX * Math.Sin(2 * Math.PI * y / frecuenciaX + posx));

                    // Aplicar ruido aleatorio
                    if (rnd.Next(100) < cantidadRuido)
                    {
                        int ruido = rnd.Next(256);
                        Color pixelRuido = Color.FromArgb(ruido, ruido, ruido);
                        rColor = pixelRuido;
                    }
                    else
                    {
                        // Aplicar interferencia aleatoria
                        if (rnd.Next(100) < cantidadInterferencia)
                        {
                            int offsetX = rnd.Next(-5, 5);
                            int offsetY = rnd.Next(-5, 5);
                            nuevoX += offsetX;
                            int nuevoY = y + offsetY;

                            if (nuevoX >= 0 && nuevoX - offsetX < original.Width && nuevoY >= 0 && nuevoY < original.Height)
                            {
                                //Color pixelInterferencia = original.GetPixel(nuevoX, nuevoY);

                                r = nuevoX < original.Width ? original.GetPixel(nuevoX, nuevoY).R : 0;
                                g = original.GetPixel(x, y).G;
                                b = nuevoX - offsetX >= 0 ? original.GetPixel(nuevoX - offsetX, nuevoY).B : 0;

                                //rColor = pixelInterferencia;
                                rColor = Color.FromArgb(oColor.A, r, g, b);
                            }
                        }
                        else
                        {
                            // Mantener el pixel original
                            if (nuevoX >= 0 && nuevoX < original.Width)
                            {
                                //r = nuevoX + aberrancia < original.Width ? original.GetPixel(nuevoX + aberrancia, y).R : 0;
                                //g = original.GetPixel(x, y).G;
                                //b = nuevoX - aberrancia>= 0 ? original.GetPixel(nuevoX - aberrancia, y).B : 0;
                                //rColor = Color.FromArgb(oColor.A, r, g, b);

                                Color pixelOriginal = original.GetPixel(nuevoX, y);

                                rColor = pixelOriginal;
                            }
                        }
                    }

                    //rColor = Color.FromArgb(oColor.A, (rColor.R * oColor.R) / 256, (rColor.G * oColor.G) / 256, (rColor.B * oColor.B) / 256);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroInterferenciaVHS2(Bitmap original, Bitmap picture1, float posx, int cantidadRuido, int cantidadInterferencia)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            Random rnd = new Random();

            // Parámetros de efecto VHS
            //int cantidadRuido = 0;
            //int cantidadInterferencia = 50;
            //int aberrancia = 4;

            // Parámetros de deformación
            float amplitudX = 2.5f; // Amplitud en el eje X 
            int frecuenciaX = 30; // Frecuencia en el eje X

            int nuevoX;

            int r, g, b;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    nuevoX = x + (int)(amplitudX * Math.Sin(2 * Math.PI * y / frecuenciaX + posx));

                    // Aplicar ruido aleatorio
                    if (rnd.Next(100) < cantidadRuido)
                    {
                        int ruido = rnd.Next(256);
                        Color pixelRuido = Color.FromArgb(ruido, ruido, ruido);
                        rColor = pixelRuido;
                    }
                    else
                    {
                        // Aplicar interferencia aleatoria
                        if (rnd.Next(100) < cantidadInterferencia)
                        {
                            int offsetX = rnd.Next(-5, 5);
                            int offsetY = rnd.Next(-5, 5);
                            nuevoX += offsetX;
                            int nuevoY = y + offsetY;

                            if (nuevoX >= 0 && nuevoX - offsetX < original.Width && nuevoY >= 0 && nuevoY < original.Height)
                            {
                                //Color pixelInterferencia = original.GetPixel(nuevoX, nuevoY);

                                r = nuevoX < original.Width ? original.GetPixel(nuevoX, nuevoY).R : 0;
                                g = original.GetPixel(x, y).G;
                                b = nuevoX - offsetX >= 0 ? original.GetPixel(nuevoX - offsetX, nuevoY).B : 0;

                                //rColor = pixelInterferencia;
                                rColor = Color.FromArgb(oColor.A, r, g, b);
                            }
                        }
                        else
                        {
                            // Mantener el pixel original
                            if (nuevoX >= 0 && nuevoX < original.Width)
                            {
                                //r = nuevoX + aberrancia < original.Width ? original.GetPixel(nuevoX + aberrancia, y).R : 0;
                                //g = original.GetPixel(x, y).G;
                                //b = nuevoX - aberrancia>= 0 ? original.GetPixel(nuevoX - aberrancia, y).B : 0;
                                //rColor = Color.FromArgb(oColor.A, r, g, b);

                                Color pixelOriginal = original.GetPixel(nuevoX, y);

                                rColor = pixelOriginal;
                            }
                        }
                    }

                    Color pixelVHS = picture1.GetPixel(x, y);

                    int R = (rColor.R + pixelVHS.R);
                    int G = (rColor.G + pixelVHS.G);
                    int B = (rColor.B + pixelVHS.B);

                    R = R > 255 ? 255 : R;
                    G = G > 255 ? 255 : G;
                    B = B > 255 ? 255 : B;

                    rColor = Color.FromArgb(R, G, B);

                    //rColor = Color.FromArgb(oColor.A, (rColor.R * oColor.R) / 256, (rColor.G * oColor.G) / 256, (rColor.B * oColor.B) / 256);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroRuidoAleatorio1(Bitmap original)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            int porcentajeRuido = 40;
            int pRanMin = 85;
            int pRanMax = 135;
            float pBrillo = 0;

            Random rnd = new Random();

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    if (rnd.Next(1, 100) <= porcentajeRuido)
                    {
                        pBrillo = rnd.Next(pRanMin, pRanMax) / 100.0f;


                        int R = (int)(oColor.R * pBrillo);
                        int G = (int)(oColor.G * pBrillo);
                        int B = (int)(oColor.B * pBrillo);

                        R = R > 255 ? 255 : R;
                        G = G > 255 ? 255 : G;
                        B = B > 255 ? 255 : B;

                        R = R < 0 ? 0 : R;
                        G = G < 0 ? 0 : G;
                        B = B < 0 ? 0 : B;

                        rColor = Color.FromArgb(oColor.A, R, G, B);
                    }
                    else
                    {
                        rColor = Color.FromArgb(oColor.A, oColor.R, oColor.G, oColor.B);
                    }

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroRuidoAleatorio2(Bitmap original, int porcentajeRuido)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            Random rnd = new Random();

            //int porcentajeRuido = 1;

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    if (rnd.Next(1, 100) <= porcentajeRuido)
                    {
                        int pRanMin = rnd.Next(0, 255);
                        int pRanMax = rnd.Next(pRanMin, 255);

                        int R = rnd.Next(0, 255) + oColor.R;
                        int G = rnd.Next(0, 255) + oColor.G;
                        int B = rnd.Next(0, 255) + oColor.B;

                        R = R > 255 ? 255 : R;
                        G = G > 255 ? 255 : G;
                        B = B > 255 ? 255 : B;

                        R = R < 0 ? 0 : R;
                        G = G < 0 ? 0 : G;
                        B = B < 0 ? 0 : B;

                        rColor = Color.FromArgb(oColor.A, R, G, B);
                    }
                    else
                    {
                        rColor = Color.FromArgb(oColor.A, oColor.R, oColor.G, oColor.B);
                    }

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }

        public Bitmap filtroDeformacionOndas(Bitmap original, float posx, float posy)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            // Parámetros de deformación
            int amplitudX = 3; // Amplitud en el eje X (ajusta según tus necesidades)
            int frecuenciaX = 30; // Frecuencia en el eje X (ajusta según tus necesidades)
            int amplitudY = 2; // Amplitud en el eje Y (ajusta según tus necesidades)
            int frecuenciaY = 30; // Frecuencia en el eje Y (ajusta según tus necesidades)

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    int nuevoX = x + (int)(amplitudX * Math.Sin(2 * Math.PI * y / frecuenciaX + posx));
                    int nuevoY = y + (int)(amplitudY * Math.Sin(2 * Math.PI * x / frecuenciaY + posy));

                    if (nuevoX >= 0 && nuevoX < original.Width && nuevoY >= 0 && nuevoY < original.Height)
                    {
                        Color pixel = original.GetPixel(nuevoX, nuevoY);
                        resultado.SetPixel(x, y, pixel);
                    }
                }
            }

            return resultado;
        }

        public Bitmap filtroEnsombrecer_Iluminar(Bitmap original, float iluminiacion, float sombras)
        {
            Bitmap resultado = new Bitmap(original.Width, original.Height);

            Color oColor = new Color();
            Color rColor = new Color();

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    int nRojo = (int)(oColor.R * iluminiacion);
                    int nVerde = (int)(oColor.G * iluminiacion);
                    int nAzul = (int)(oColor.B * iluminiacion);

                    nRojo = nRojo > 255 ? 255 : nRojo;
                    nVerde = nVerde > 255 ? 255 : nVerde;
                    nAzul = nAzul > 255 ? 255 : nAzul;

                    nRojo = (int)(nRojo * sombras);
                    nVerde = (int)(nVerde * sombras);
                    nAzul = (int)(nAzul * sombras);

                    rColor = Color.FromArgb(oColor.A, nRojo, nVerde, nAzul);

                    resultado.SetPixel(x, y, rColor);
                }
            }

            return resultado;
        }




        //CAPAS DE FILTROS DE APOYO

        //Funcion para sumar 2 imagenes
        public Bitmap suma(Bitmap imagen1, Bitmap imagen2)
        {
            Bitmap resultado = new Bitmap(imagen1.Width, imagen1.Height);

            Color oColor1 = new Color();
            Color oColor2 = new Color();
            Color rColor = new Color();
            imagen2.SetResolution(imagen1.Width, imagen1.Height);

            for (int x = 0; x < imagen1.Height; x++)
            {
                for (int y = 0; y < imagen1.Width; y++)
                {
                    oColor1 = imagen1.GetPixel(y, x);
                    oColor2 = imagen2.GetPixel(y, x);

                    rColor = Color.FromArgb(oColor1.A, (oColor1.R + oColor2.R) /2, (oColor1.G + oColor2.G) / 2, (oColor1.B + oColor2.B) / 2);

                    resultado.SetPixel(y, x, rColor);
                }
            }

            return resultado;
        }

        // Crear un kernel gaussiano
        private static double[,] CrearKernelGaussiano(int radio)
        {
            int tamaño = 2 * radio + 1;
            double[,] kernel = new double[tamaño, tamaño];
            double sigma = radio / 3.0; // Puedes ajustar este valor según la intensidad del desenfoque

            double dosSigmaCuadrado = 2 * sigma * sigma;
            double sumaTotal = 0.0;

            for (int x = -radio; x <= radio; x++)
            {
                for (int y = -radio; y <= radio; y++)
                {
                    double exponente = -(x * x + y * y) / dosSigmaCuadrado;
                    kernel[x + radio, y + radio] = Math.Exp(exponente) / (Math.PI * dosSigmaCuadrado);
                    sumaTotal += kernel[x + radio, y + radio];
                }
            }

            // Normalizar el kernel
            for (int x = 0; x < tamaño; x++)
            {
                for (int y = 0; y < tamaño; y++)
                {
                    kernel[x, y] /= sumaTotal;
                }
            }

            return kernel;
        }

        // Aplicar el filtro de desenfoque gaussiano a un píxel
        private static Color AplicarFiltroGaussiano(Bitmap imagen, int x, int y, double[,] kernel, int radio)
        {
            int tamaño = 2 * radio + 1;
            int ancho = imagen.Width;
            int alto = imagen.Height;
            double acumuladoR = 0.0;
            double acumuladoG = 0.0;
            double acumuladoB = 0.0;

            for (int i = -radio; i <= radio; i++)
            {
                for (int j = -radio; j <= radio; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Asegurarse de que el píxel está dentro de los límites de la imagen
                    if (pixelX >= 0 && pixelX < ancho && pixelY >= 0 && pixelY < alto)
                    {
                        Color pixel = imagen.GetPixel(pixelX, pixelY);
                        double factor = kernel[i + radio, j + radio];

                        acumuladoR += pixel.R * factor;
                        acumuladoG += pixel.G * factor;
                        acumuladoB += pixel.B * factor;
                    }
                }
            }

            return Color.FromArgb((int)acumuladoR, (int)acumuladoG, (int)acumuladoB);
        }

        // Aplicar el filtro de enfoque laplaciano a un píxel
        private static Color AplicarFiltroLaplaciano(Bitmap imagen, int x, int y, int[,] kernel)
        {
            int ancho = imagen.Width;
            int alto = imagen.Height;
            int acumuladoR = 0;
            int acumuladoG = 0;
            int acumuladoB = 0;

            int tamaño = kernel.GetLength(0);
            int radio = tamaño / 2;

            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    int pixelX = x + i - radio;
                    int pixelY = y + j - radio;

                    // Asegurarse de que el píxel está dentro de los límites de la imagen
                    if (pixelX >= 0 && pixelX < ancho && pixelY >= 0 && pixelY < alto)
                    {
                        Color pixel = imagen.GetPixel(pixelX, pixelY);
                        int factor = kernel[i, j];

                        acumuladoR += pixel.R * factor;
                        acumuladoG += pixel.G * factor;
                        acumuladoB += pixel.B * factor;
                    }
                }
            }

            // Asegurarse de que los valores de píxel estén en el rango válido (0-255)
            acumuladoR = Math.Max(0, Math.Min(255, acumuladoR));
            acumuladoG = Math.Max(0, Math.Min(255, acumuladoG));
            acumuladoB = Math.Max(0, Math.Min(255, acumuladoB));

            return Color.FromArgb(acumuladoR, acumuladoG, acumuladoB);
        }

        // Aplicar el filtro de mediana a un píxel
        private static Color AplicarFiltroMediana(Bitmap imagen, int x, int y, int tamañoVentana)
        {
            int ancho = imagen.Width;
            int alto = imagen.Height;
            int radio = tamañoVentana / 2;
            int[] valoresR = new int[tamañoVentana * tamañoVentana];
            int[] valoresG = new int[tamañoVentana * tamañoVentana];
            int[] valoresB = new int[tamañoVentana * tamañoVentana];

            int índice = 0;

            for (int i = -radio; i <= radio; i++)
            {
                for (int j = -radio; j <= radio; j++)
                {
                    int pixelX = x + i;
                    int pixelY = y + j;

                    // Asegurarse de que el píxel está dentro de los límites de la imagen
                    if ((pixelX >= 0 && pixelX < ancho) && (pixelY >= 0 && pixelY < alto))
                    {
                        Color pixel = imagen.GetPixel(pixelX, pixelY);
                        valoresR[índice] = pixel.R;
                        valoresG[índice] = pixel.G;
                        valoresB[índice] = pixel.B;
                    }
                    else
                    {
                        // Si el píxel está fuera de los límites, asumir un valor de cero (negro)
                        valoresR[índice] = 0;
                        valoresG[índice] = 0;
                        valoresB[índice] = 0;
                    }

                    índice++;
                }
            }

            // Ordenar los valores de los canales de color
            Array.Sort(valoresR);
            Array.Sort(valoresG);
            Array.Sort(valoresB);

            // Tomar el valor medio como resultado
            int valorR = valoresR[valoresR.Length / 2];
            int valorG = valoresG[valoresG.Length / 2];
            int valorB = valoresB[valoresB.Length / 2];

            return Color.FromArgb(valorR, valorG, valorB);
        }

    }
}
