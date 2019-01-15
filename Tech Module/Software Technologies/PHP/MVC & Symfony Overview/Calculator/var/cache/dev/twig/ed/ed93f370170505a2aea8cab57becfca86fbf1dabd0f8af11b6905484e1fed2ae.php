<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_c51e6a841bb0db29eb90c50b3cc3cbeb2c3f3739b980a05ad6532e17354374f8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_ef23d90adab6610e56a0b9f8ce78d83b70371a54126af7672b973c9894ec73fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ef23d90adab6610e56a0b9f8ce78d83b70371a54126af7672b973c9894ec73fa->enter($__internal_ef23d90adab6610e56a0b9f8ce78d83b70371a54126af7672b973c9894ec73fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_ef23d90adab6610e56a0b9f8ce78d83b70371a54126af7672b973c9894ec73fa->leave($__internal_ef23d90adab6610e56a0b9f8ce78d83b70371a54126af7672b973c9894ec73fa_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_0e441e7976d6a5819a485ad33fa5ca4746b4d23c35109c99d2f209c1e1a6425b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0e441e7976d6a5819a485ad33fa5ca4746b4d23c35109c99d2f209c1e1a6425b->enter($__internal_0e441e7976d6a5819a485ad33fa5ca4746b4d23c35109c99d2f209c1e1a6425b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_0e441e7976d6a5819a485ad33fa5ca4746b4d23c35109c99d2f209c1e1a6425b->leave($__internal_0e441e7976d6a5819a485ad33fa5ca4746b4d23c35109c99d2f209c1e1a6425b_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_3bbf681efd38134b9d3576eb2006d13684765339500a773c3f3fc487adf286cc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3bbf681efd38134b9d3576eb2006d13684765339500a773c3f3fc487adf286cc->enter($__internal_3bbf681efd38134b9d3576eb2006d13684765339500a773c3f3fc487adf286cc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_3bbf681efd38134b9d3576eb2006d13684765339500a773c3f3fc487adf286cc->leave($__internal_3bbf681efd38134b9d3576eb2006d13684765339500a773c3f3fc487adf286cc_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_117a47689f744afb3c64e58522113c2b22b99d88e1aa4f7684ce2efe4ad553a8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_117a47689f744afb3c64e58522113c2b22b99d88e1aa4f7684ce2efe4ad553a8->enter($__internal_117a47689f744afb3c64e58522113c2b22b99d88e1aa4f7684ce2efe4ad553a8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_117a47689f744afb3c64e58522113c2b22b99d88e1aa4f7684ce2efe4ad553a8->leave($__internal_117a47689f744afb3c64e58522113c2b22b99d88e1aa4f7684ce2efe4ad553a8_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
