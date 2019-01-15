<?php

/* user/profile.html.twig */
class __TwigTemplate_a1dbcf50a6aa30f8f7fec3f4bc0b48eedb1c6670611bb455e83c50393da4772a extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "user/profile.html.twig", 1);
        $this->blocks = array(
            'body_id' => array($this, 'block_body_id'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_18d20e1a055b4ea72e024921cc32671268e5d32560e1bd4b4dab532da92de471 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_18d20e1a055b4ea72e024921cc32671268e5d32560e1bd4b4dab532da92de471->enter($__internal_18d20e1a055b4ea72e024921cc32671268e5d32560e1bd4b4dab532da92de471_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "user/profile.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_18d20e1a055b4ea72e024921cc32671268e5d32560e1bd4b4dab532da92de471->leave($__internal_18d20e1a055b4ea72e024921cc32671268e5d32560e1bd4b4dab532da92de471_prof);

    }

    // line 3
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_01fee29d8d6cd7eba4812ddd5cf77695b2f2107dd47f8366526039bca9f65bb5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_01fee29d8d6cd7eba4812ddd5cf77695b2f2107dd47f8366526039bca9f65bb5->enter($__internal_01fee29d8d6cd7eba4812ddd5cf77695b2f2107dd47f8366526039bca9f65bb5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        echo "profile";
        
        $__internal_01fee29d8d6cd7eba4812ddd5cf77695b2f2107dd47f8366526039bca9f65bb5->leave($__internal_01fee29d8d6cd7eba4812ddd5cf77695b2f2107dd47f8366526039bca9f65bb5_prof);

    }

    // line 5
    public function block_main($context, array $blocks = array())
    {
        $__internal_dbb5fa62eb2f12d56367599ee01fdb99b723bc0b11eefabeafab7d20e9b321b7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dbb5fa62eb2f12d56367599ee01fdb99b723bc0b11eefabeafab7d20e9b321b7->enter($__internal_dbb5fa62eb2f12d56367599ee01fdb99b723bc0b11eefabeafab7d20e9b321b7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 6
        echo "    <div>
        ";
        // line 7
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["user"]) ? $context["user"] : $this->getContext($context, "user")), "email", array()), "html", null, true);
        echo "
        <br>
        ";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["user"]) ? $context["user"] : $this->getContext($context, "user")), "fullName", array()), "html", null, true);
        echo "
    </div>
";
        
        $__internal_dbb5fa62eb2f12d56367599ee01fdb99b723bc0b11eefabeafab7d20e9b321b7->leave($__internal_dbb5fa62eb2f12d56367599ee01fdb99b723bc0b11eefabeafab7d20e9b321b7_prof);

    }

    public function getTemplateName()
    {
        return "user/profile.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  61 => 9,  56 => 7,  53 => 6,  47 => 5,  35 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends 'base.html.twig' %}

{% block body_id 'profile' %}

{% block main %}
    <div>
        {{ user.email }}
        <br>
        {{ user.fullName }}
    </div>
{% endblock %}
";
    }
}
