#version 330 core
#extension GL_ARB_separate_shader_objects : enable

in vec3 ourColor;

out vec4 FragColor;

void main()
{
    FragColor = vec4(ourColor, 1.0f);
}