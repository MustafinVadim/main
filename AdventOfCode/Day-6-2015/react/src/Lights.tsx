import React, {useEffect, useRef } from "react";
import "./Lights.css";

const Lights: React.FC = () => {
    const canvasRef = useRef<HTMLCanvasElement>(null);

    useEffect(() => {
        if (!canvasRef.current)
            return;

        const canvas = canvasRef.current;
        const context = canvas.getContext('2d',  { alpha: false });

        if (!context)
            return;


        let imgData = context.createImageData(1000, 1000);
        context.fillStyle = '#a13434';

        context.putImageData(imgData, 0, 0);

    }, []);

    return <canvas className={"Lights"} ref={canvasRef}/>;
};

export default Lights;