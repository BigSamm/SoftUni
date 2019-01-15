<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_ac3c65cdec9531f56f85e3eb103b4daf5a94beb941ace93f78e388820cf3b446 extends Twig_Template
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
        $__internal_254469ea16dab218181595c37723c022559e5d7d72df57a347e867d4420fc460 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_254469ea16dab218181595c37723c022559e5d7d72df57a347e867d4420fc460->enter($__internal_254469ea16dab218181595c37723c022559e5d7d72df57a347e867d4420fc460_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_254469ea16dab218181595c37723c022559e5d7d72df57a347e867d4420fc460->leave($__internal_254469ea16dab218181595c37723c022559e5d7d72df57a347e867d4420fc460_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_adccd312ce9de4291829eb28658ca981e14c5f73b025619421d6937f3a778c60 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_adccd312ce9de4291829eb28658ca981e14c5f73b025619421d6937f3a778c60->enter($__internal_adccd312ce9de4291829eb28658ca981e14c5f73b025619421d6937f3a778c60_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_adccd312ce9de4291829eb28658ca981e14c5f73b025619421d6937f3a778c60->leave($__internal_adccd312ce9de4291829eb28658ca981e14c5f73b025619421d6937f3a778c60_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_f1dcb401f9133c6700eeed79b60cabac1a07d69a8fafc2c5af9fd06aeec9907f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f1dcb401f9133c6700eeed79b60cabac1a07d69a8fafc2c5af9fd06aeec9907f->enter($__internal_f1dcb401f9133c6700eeed79b60cabac1a07d69a8fafc2c5af9fd06aeec9907f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_f1dcb401f9133c6700eeed79b60cabac1a07d69a8fafc2c5af9fd06aeec9907f->leave($__internal_f1dcb401f9133c6700eeed79b60cabac1a07d69a8fafc2c5af9fd06aeec9907f_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_f44b85642920500221b87fd8808fd715bea5727773e6a86b0d69b406b82e6f81 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f44b85642920500221b87fd8808fd715bea5727773e6a86b0d69b406b82e6f81->enter($__internal_f44b85642920500221b87fd8808fd715bea5727773e6a86b0d69b406b82e6f81_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_f44b85642920500221b87fd8808fd715bea5727773e6a86b0d69b406b82e6f81->leave($__internal_f44b85642920500221b87fd8808fd715bea5727773e6a86b0d69b406b82e6f81_prof);

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
