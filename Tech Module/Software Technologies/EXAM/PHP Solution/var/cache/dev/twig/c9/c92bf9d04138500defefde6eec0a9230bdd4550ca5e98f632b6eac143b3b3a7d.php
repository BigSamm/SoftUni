<?php

/* anime/index.html.twig */
class __TwigTemplate_c0c265c94107021d662eaae3d026d9ae53f2ed7b1e517fefaa678d36d065be5b extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "anime/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_cb60a8908614d8d7515266406f8579545c8125e60dacde5eecabea288e364b4c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cb60a8908614d8d7515266406f8579545c8125e60dacde5eecabea288e364b4c->enter($__internal_cb60a8908614d8d7515266406f8579545c8125e60dacde5eecabea288e364b4c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/index.html.twig"));

        $__internal_44006765f341fabfdf6991f2c25b419d58a113eb4caa8e893a71088e1da43334 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_44006765f341fabfdf6991f2c25b419d58a113eb4caa8e893a71088e1da43334->enter($__internal_44006765f341fabfdf6991f2c25b419d58a113eb4caa8e893a71088e1da43334_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_cb60a8908614d8d7515266406f8579545c8125e60dacde5eecabea288e364b4c->leave($__internal_cb60a8908614d8d7515266406f8579545c8125e60dacde5eecabea288e364b4c_prof);

        
        $__internal_44006765f341fabfdf6991f2c25b419d58a113eb4caa8e893a71088e1da43334->leave($__internal_44006765f341fabfdf6991f2c25b419d58a113eb4caa8e893a71088e1da43334_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_ceb29124ea7713fc56f2c1b6333c4147db955c347f7df56325cec325d97e295a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ceb29124ea7713fc56f2c1b6333c4147db955c347f7df56325cec325d97e295a->enter($__internal_ceb29124ea7713fc56f2c1b6333c4147db955c347f7df56325cec325d97e295a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_d7cdcc83a99a1b3c9460e484add0319289379de093c51e4b708de8f96c2ff111 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d7cdcc83a99a1b3c9460e484add0319289379de093c51e4b708de8f96c2ff111->enter($__internal_d7cdcc83a99a1b3c9460e484add0319289379de093c51e4b708de8f96c2ff111_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Anime List</h1>

<section>
    <div>
        <table>
            <tr>
                <th>Rating</th>
                <th>Name</th>
                <th>Description</th>
                <th>Watched</th>
                <th>Actions</th>
            </tr>
            ";
        // line 16
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["animes"] ?? $this->getContext($context, "animes")));
        foreach ($context['_seq'] as $context["_key"] => $context["anime"]) {
            // line 17
            echo "            <tr>
                <td>";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "rating", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 19
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 20
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "description", array()), "html", null, true);
            echo "</td>
                <td>
                    <input class=\"checkbox\" type=\"checkbox\" value=\"";
            // line 22
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "watched", array()), "html", null, true);
            echo "\" onclick=\"preventEvent(event)\" name=\"";
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "\" />
                    <label for=\"";
            // line 23
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "\"></label>
                </td>
                <td>
                    <button class=\"delete\" onclick=\"location.href='/delete/";
            // line 26
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "id", array()), "html", null, true);
            echo "'\">Delete</button>
                </td>
            </tr>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['anime'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 30
        echo "        </table>
    </div>
</section>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">+</button>
</div>

<script>
    function preventEvent(ev) {
        ev.preventDefault();
    }
    (function checkBox() {
        let checkboxes = document.getElementsByClassName(\"checkbox\");

        for(let i = 0; i < checkboxes.length; i++) {
            if(checkboxes[i].value === \"watched\") {
                checkboxes[i].checked = true;
            }
        }
    })();
</script>
";
        
        $__internal_d7cdcc83a99a1b3c9460e484add0319289379de093c51e4b708de8f96c2ff111->leave($__internal_d7cdcc83a99a1b3c9460e484add0319289379de093c51e4b708de8f96c2ff111_prof);

        
        $__internal_ceb29124ea7713fc56f2c1b6333c4147db955c347f7df56325cec325d97e295a->leave($__internal_ceb29124ea7713fc56f2c1b6333c4147db955c347f7df56325cec325d97e295a_prof);

    }

    public function getTemplateName()
    {
        return "anime/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  105 => 30,  95 => 26,  89 => 23,  83 => 22,  78 => 20,  74 => 19,  70 => 18,  67 => 17,  63 => 16,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>Anime List</h1>

<section>
    <div>
        <table>
            <tr>
                <th>Rating</th>
                <th>Name</th>
                <th>Description</th>
                <th>Watched</th>
                <th>Actions</th>
            </tr>
            {% for anime in animes %}
            <tr>
                <td>{{ anime.rating }}</td>
                <td>{{ anime.name }}</td>
                <td>{{ anime.description }}</td>
                <td>
                    <input class=\"checkbox\" type=\"checkbox\" value=\"{{ anime.watched }}\" onclick=\"preventEvent(event)\" name=\"{{ anime.name }}\" />
                    <label for=\"{{ anime.name }}\"></label>
                </td>
                <td>
                    <button class=\"delete\" onclick=\"location.href='/delete/{{ anime.id }}'\">Delete</button>
                </td>
            </tr>
            {% endfor %}
        </table>
    </div>
</section>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">+</button>
</div>

<script>
    function preventEvent(ev) {
        ev.preventDefault();
    }
    (function checkBox() {
        let checkboxes = document.getElementsByClassName(\"checkbox\");

        for(let i = 0; i < checkboxes.length; i++) {
            if(checkboxes[i].value === \"watched\") {
                checkboxes[i].checked = true;
            }
        }
    })();
</script>
{% endblock %}", "anime/index.html.twig", "D:\\PHP Solution\\app\\Resources\\views\\anime\\index.html.twig");
    }
}
