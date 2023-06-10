#version 330

// Input vertex attributes (from vertex shader)
in vec2 fragTexCoord;
in vec4 fragColor;


uniform sampler2D texture0;
uniform vec4 colDiffuse;

out vec4 finalColor;


vec3 palette( in float t, in vec3 a, in vec3 b, in vec3 c, in vec3 d )
{
    return a + b*cos( 6.28318*(c*t+d) );
}

void main(){

    vec4 t = texture(texture0,fragTexCoord);
    if(t.r != 0.0){
        //vec3 palettized = palette(t.r,vec3(0.5,0.5,0.5),vec3(0.5,0.5,0.5),vec3(1.0,1.0,1.0),vec3(0.0,0.333,0.667));
        vec3 palettized = palette(t.r,vec3(0.938,0.328,0.718),vec3(0.659,0.438,0.328),vec3(0.388,0.388,0.296),vec3(2.538,2.478,0.168));
        finalColor = vec4(palettized,1);
    }
    else
        finalColor = t;

    
}
