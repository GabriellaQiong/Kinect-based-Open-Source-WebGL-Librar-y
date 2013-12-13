/*
 *
 *  Peter R. Elespuru
 *
 *  modified from:
 * http://www.geeks3d.com/20091020/shader-library-lens-circle-post-processing-effect-glsl/
 */

uniform sampler2D img;
varying vec2 vUv;
//uniform vec2 lensRadius; // 0.45, 0.38

void main() {
	
	vec2 lensRadius = vec2(0.80, 0.4);
	vec4 rgba = texture2D(img, vUv.xy);
    float d = distance(vUv.xy, vec2(0.5,0.5));
    rgba *= smoothstep(lensRadius.x, lensRadius.y, d);
    gl_FragColor = rgba;
}
